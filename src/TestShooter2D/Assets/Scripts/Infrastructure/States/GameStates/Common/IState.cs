namespace Infrastructure.States.GameStates.Common
{
    public interface IState : IExitableState
    {
        public void Enter();
    }
}