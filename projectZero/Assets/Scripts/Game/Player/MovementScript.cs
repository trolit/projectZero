using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class MovementScript : MonoBehaviour
    {
        private Animator _animator;

        private Rigidbody _transform;

        [SerializeField]
        public AudioSource SfxSource;

        [SerializeField]
        public float Speed;

        // For RoboLightScript 
        public static bool IsMoving = false;

        // Start is called before the first frame update
        void Start()
        {
            _animator = GetComponent<Animator>();

            _transform = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            // Stop walk animation
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) ||
                Input.GetKeyUp(KeyCode.D))
            {
                _animator.SetBool("Move", false);

                IsMoving = false;
            }

            // Run walk animation
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.D))
            {
                _animator.SetBool("Move", true);

                IsMoving = true;

                if(SfxSource.isPlaying == false && IsMoving)
                    SfxSource.Play();
            }
        }

        void FixedUpdate()
        {
            // Move forward
            if (Input.GetKey(KeyCode.W))
            {
                _transform.AddForce(new Vector3(0, 0, 5) * Speed, ForceMode.VelocityChange);
                
                _transform.rotation = Quaternion.LookRotation(Vector3.forward);
            }

            // Move left
            if (Input.GetKey(KeyCode.A))
            {
                _transform.AddForce(new Vector3(-5, 0, 0) * Speed, ForceMode.VelocityChange);

                _transform.rotation = Quaternion.LookRotation(Vector3.left);
            }

            // Move back
            if (Input.GetKey(KeyCode.S))
            {
                _transform.AddForce(new Vector3(0, 0, -5) * Speed, ForceMode.VelocityChange);

                _transform.rotation = Quaternion.LookRotation(Vector3.back);
            }

            // Move right
            if (Input.GetKey(KeyCode.D))
            {
                _transform.AddForce(new Vector3(5, 0, 0) * Speed, ForceMode.VelocityChange);

                _transform.rotation = Quaternion.LookRotation(Vector3.right);
            }

            // Falling force
            _transform.AddForce(new Vector3(0, -2, 0) * Speed, ForceMode.VelocityChange);
        }
    }
}
