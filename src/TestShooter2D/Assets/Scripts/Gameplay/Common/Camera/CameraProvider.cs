using UnityEngine;

namespace Gameplay.Common.Camera
{
    public class CameraProvider : ICameraProvider
    {
        public UnityEngine.Camera Camera { get; set; }

        public void SetPositionX(float x)
        {
            var position = Camera.gameObject.transform.position;

            position = new Vector3(x, position.y, position.z);

            Camera.gameObject.transform.position = position;
        }
    }
}