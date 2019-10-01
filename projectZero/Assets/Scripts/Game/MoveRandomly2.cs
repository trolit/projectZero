using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS 2 ANIMATIONS 

    // Warning: Animator needs to contain Walk parameter
    // of type Integer
    [RequireComponent(typeof(NavMeshAgent))]
    public class MoveRandomly2 : MonoBehaviour
    {
        public float TimeForNewState;
        public float XValue; 
        public float ZValue;

        // from 5 to 20 seconds by default
        // enables/disables TimeRandomizer method
        public bool _randomTimeForNewState = false;

        private NavMeshAgent _navMeshAgent;
        private bool _inCoRoutine;
        private Vector3 _target;
        private Animator _animator;

        // Use this for initialization
        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();

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
            if (!_inCoRoutine)
                StartCoroutine(DoSomething());
        }

        private IEnumerator DoSomething()
        {
            _inCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewState);

            var result = StateRandomizer();

            if (_randomTimeForNewState == true)
            {
                TimeForNewState = TimeRandomizer(5, 20);
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

