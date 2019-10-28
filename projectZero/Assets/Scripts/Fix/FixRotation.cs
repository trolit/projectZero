using UnityEngine;

namespace Assets.Scripts.Fix
{
    public class FixRotation : MonoBehaviour
    {
        Quaternion _rotation;

        private void Awake()
        {
            _rotation = transform.rotation;
        }

        private void LateUpdate()
        {
            transform.rotation = _rotation;
        }
    }
}
