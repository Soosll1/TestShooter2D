using Entitas;
using Gameplay.Input.Service;
using UnityEngine;

namespace Gameplay.Input.Systems
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly IInputService _inputService;
        private readonly IGroup<GameEntity> _inputs;

        public EmitInputSystem(GameContext game, IInputService inputService)
        {
            _inputService = inputService;
            _inputs = game.GetGroup(GameMatcher.Input);
        }
        
        public void Execute()
        {
            foreach (var input in _inputs)
            {
                if (_inputService.HasAxisInput())
                    input.ReplaceAxisInput(new Vector2(_inputService.GetHorizontalAxis(), _inputService.GetVerticalAxis()));

                else if(input.hasAxisInput)
                    input.RemoveAxisInput();

                if (_inputService.GetLeftMouseButton())
                    input.isLeftButtonInput = true;

                else
                    input.isLeftButtonInput = false;
            }
        }
    }
}