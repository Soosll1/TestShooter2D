namespace Infrastructure.States.GameStates.Common
{
    public interface IPayloadState<TPayLoad> : IExitableState
    {
        public void Enter(TPayLoad sceneName);
    }
}