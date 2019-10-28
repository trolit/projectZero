using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class PlayerFollow : MonoBehaviour
    {
        public Transform PlayerTransform;

        private Vector3 _cameraOffset;

        [Range(0.01f, 1.0f)]
        public float SmoothFactor = 0.5f;

        // Start is called before the first frame update
        private void Start()
        {
            _cameraOffset = transform.position - PlayerTransform.position;
        }

        // LateUpdate is called after Update methods
        private void LateUpdate()
        {
            Vector3 newPos = PlayerTransform.position + _cameraOffset;

            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        }
    }
}
