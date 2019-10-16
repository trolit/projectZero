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
        private int _upPower = 10;

        [SerializeField]
        [Range(0.0f, 75.0f)]
        private int _downPower = 10;

        [SerializeField]
        [Range(0.0f, 50.0f)]
        private float _sidePower = 25f;

        [SerializeField]
        [Range(0.0f, 50.0f)]
        private float _rotationPower = 25f;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Vector3 dir = other.transform.position - transform.position;
                dir.Normalize();


                _rigidbody.AddForce(-dir * _sidePower, ForceMode.Impulse);
                _rigidbody.AddForce(transform.up * _upPower, ForceMode.Impulse);
                _rigidbody.AddTorque(-dir * _rotationPower, ForceMode.Impulse);
                Invoke("ForceToGround", 0.5f);
                //var playerPos = other.gameObject.transform;

                //ForceLeaf(playerPos);
            }
        }

        private void ForceToGround()
        {
            _rigidbody.AddForce(-transform.up * _downPower, ForceMode.Impulse);
            _rigidbody.AddTorque(-transform.up * _rotationPower, ForceMode.Impulse);
        }
    }
}
