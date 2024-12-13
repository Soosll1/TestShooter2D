namespace Gameplay.Common.Camera
{
    public interface ICameraProvider
    {
        UnityEngine.Camera Camera { get; set; }
        void SetPositionX(float x);
    }
}