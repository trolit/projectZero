using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS 2 ANIMATIONS AND SOUND
    // EFFECT TO PLAY WHEN PLAYER GETS CLOSE

    // Warning: Animator needs to contain Walk parameter
    // of type Integer where value 0 means Idle and value
    // 1 means Walk

    // Warning: SphereCollider MUST BE SET as TRIGGER!
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(AudioSource))]
    public class MoveRandomly3 : MonoBehaviour
    {
        public float TimeForNewState;
        public float XValue; 
        public float ZValue;

        // enables/disables TimeRandomizer method
        public bool _randomTimeForNewState = false;

        public float minTime = 5f;
        public float maxTime = 20f;

        public AudioClip SoundEffect;

        private NavMeshAgent _navMeshAgent;
        private bool _inCoRoutine;
        private Vector3 _target;
        private Animator _animator;
        private AudioSource _soundSource;

        // Use this for initialization
        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();

            _soundSource = GetComponent<AudioSource>();

            _animator = GetComponent<Animator>();
            
            if (_animator == null)
            {
                Debug.LogError($"Object {gameObject.name} does NOT contain REQUIRED Animator component!");

                Debug.Break();
            }

            GetNewPath();
        }

        // Update is called once per frame
        private void Update()
        {
            // If reached destination - stop walk animation
            if (!_navMeshAgent.pathPending)
            {
                if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
                {
                    if (!_navMeshAgent.hasPath || _navMeshAgent.velocity.sqrMagnitude == 0f)
                    {
                        _animator.SetInteger("Walk", 0);
                    }
                }
            }

            if (!_inCoRoutine)
                StartCoroutine(DoSomething());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _soundSource.PlayOneShot(SoundEffect);
            }
        }

        private IEnumerator DoSomething()
        {
            _inCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewState);

            var result = StateRandomizer();

            if (_randomTimeForNewState == true)
            {
                TimeForNewState = TimeRandomizer(minTime, maxTime);
            }

            if (result == 0)
            {
                // Stay in place
                _navMeshAgent.isStopped = true;
                _animator.SetInteger("Walk", 0);
            }
            else if (result == 1)
            {
                // Move to the new path
                _navMeshAgent.isStopped = false;
                _animator.SetInteger("Walk", 1);

                GetNewPath();

                while (_navMeshAgent.pathPending == false)
                {
                    Debug.Log("Path not reachable !");
                    Debug.Log("Coordinates: (X - " + _navMeshAgent.destination.x + ")" +
                              " (Z - " + _navMeshAgent.destination.z + ")");

                    yield return new WaitForSeconds(0.01f);

                    GetNewPath();
                }
            }

            _inCoRoutine = false;
        }

        private int StateRandomizer()
        {
            // Returns 0 or 1 
            var result = Random.Range(0, 2);

            return result;
        }

        private float TimeRandomizer(float min, float max)
        {
            var result = Random.Range(min, max);

            return result;
        }

        private void GetNewPath()
        {
            _target = GetNewRandomPosition();
            _navMeshAgent.SetDestination(_target);
        }

        private Vector3 GetNewRandomPosition()
        {
            var x = Random.Range(-XValue, XValue);

            var z = Random.Range(-ZValue, ZValue);

            var pos = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

            return pos;
        }
    }
}

