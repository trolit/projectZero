using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS 2 ANIMATIONS 

    // Warning: Animator needs to contain Walk parameter
    // of type Integer where value 0 means Idle and value
    // 1 means Walk

    public class MoveRandomly2 : MoveRandomlyBase
    {
        public float TimeForNewState;

        // from 5 to 20 seconds by default
        // enables/disables TimeRandomizer method
        [Tooltip("Enable this to randomize states between min and max value.")]
        public bool _randomTimeForNewState = false;

        public float minTime = 5f;
        public float maxTime = 20f;

        private Animator _animator;

        // Use this for initialization
        private void Start()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();

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
            if (!NavMeshAgent.pathPending)
            {
                if (NavMeshAgent.remainingDistance <= NavMeshAgent.stoppingDistance)
                {
                    if (!NavMeshAgent.hasPath || NavMeshAgent.velocity.sqrMagnitude == 0f)
                    {
                        _animator.SetInteger("Walk", 0);
                    }
                }
            }

            if (!InCoRoutine)
                StartCoroutine(DoSomething());
        }

        private IEnumerator DoSomething()
        {
            InCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewState);

            var result = StateRandomizer();

            if (_randomTimeForNewState == true)
            {
                TimeForNewState = TimeRandomizer(minTime, maxTime);
            }

            if (result == 0)
            {
                // Stay in place
                NavMeshAgent.isStopped = true;
                _animator.SetInteger("Walk", 0);
            }
            else if (result == 1)
            {
                // Move to the new path
                NavMeshAgent.isStopped = false;
                _animator.SetInteger("Walk", 1);

                GetNewPath();

                while (NavMeshAgent.pathPending == false)
                {
                    Debug.Log("Path not reachable !");
                    Debug.Log("Coordinates: (X - " + NavMeshAgent.destination.x + ")" +
                              " (Z - " + NavMeshAgent.destination.z + ")");

                    yield return new WaitForSeconds(0.01f);

                    GetNewPath();
                }
            }

            InCoRoutine = false;
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
    }
}

