using UnityEngine;

namespace Assets.Scripts.Fix
{
    public class FixRotation : MonoBehaviour
    {
        Quaternion _rotation;

        void Awake()
        {
            _rotation = transform.rotation;
        }

        void LateUpdate()
        {
            transform.rotation = _rotation;
        }
    }
}
