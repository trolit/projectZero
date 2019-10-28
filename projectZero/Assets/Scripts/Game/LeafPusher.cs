using UnityEngine;

namespace Assets.Scripts.Game
{
    // Use SphereCollider as trigger
    // use BoxCollider as collider
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(BoxCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class LeafPusher : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        [SerializeField]
        [Range(0.0f, 50.0f)]
        private int _upPower = 27;

        [SerializeField]
        [Range(0.0f, 75.0f)]
        private int _downPower = 63;

        [SerializeField]
        [Range(0.0f, 50.0f)]
        private float _sidePower = 19.9f;

        [SerializeField]
        [Range(0.0f, 50.0f)]
        private float _rotationPower = 30.4f;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player" || other.gameObject.tag == "Animal")
            {
                var dir = other.transform.position - transform.position;

                dir.Normalize();

                _rigidbody.AddForce(-dir * _sidePower, ForceMode.Impulse);
                _rigidbody.AddForce(transform.up * _upPower, ForceMode.VelocityChange);

                var torqueRandomizer = Random.Range(0, 2);

                if (torqueRandomizer == 1)
                {
                    _rigidbody.AddTorque(-dir * _rotationPower, ForceMode.VelocityChange);
                }
                else
                {
                    _rigidbody.AddTorque(dir * _rotationPower, ForceMode.VelocityChange);
                }
            }
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(new Vector3(0, -1, 0) * 2f, ForceMode.VelocityChange);
        }
    }
}
