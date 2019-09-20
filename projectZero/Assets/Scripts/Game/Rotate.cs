using UnityEngine;

namespace Assets.Scripts.Game
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField]
        private float _rotationSpeed = 15f;

        private void Update()
        {
            transform.Rotate(Vector3.up * Time.deltaTime * _rotationSpeed);
        }
    }
}
