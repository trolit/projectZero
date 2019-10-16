using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // Class designed for MoveRandomly scripts including AT LEAST two STATES

    public class MoveRandomlyAdvanced : MoveRandomlyBase
    {
        [SerializeField]
        protected float TimeForNewState;

        // enables/disables TimeRandomizer method
        [SerializeField]
        [Tooltip("Enable this to randomize states between min and max value.")]
        protected bool RandomTimeForNewState = false;

        protected Animator Animator;

        [SerializeField]
        protected float MinTime = 5f;

        [SerializeField]
        protected float MaxTime = 20f;

        protected void Start()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();

            Animator = GetComponent<Animator>();

            if (Animator == null)
            {
                Debug.LogError($"Object {gameObject.name} does NOT contain REQUIRED Animator component!");

                Debug.Break();
            }

            GetNewPath();
        }

        protected void Update()
        {
            // If reached destination - stop walk animation
            if (!NavMeshAgent.pathPending)
            {
                if (NavMeshAgent.remainingDistance <= NavMeshAgent.stoppingDistance)
                {
                    if (!NavMeshAgent.hasPath || NavMeshAgent.velocity.sqrMagnitude == 0f)
                    {
                        Animator.SetInteger("Walk", 0);
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

            if (RandomTimeForNewState == true)
            {
                TimeForNewState = TimeRandomizer(MinTime, MaxTime);
            }

            if (result == 0)
            {
                // Stay in place
                NavMeshAgent.isStopped = true;
                Animator.SetInteger("Walk", 0);
            }
            else if (result == 1)
            {
                // Move to the new path
                NavMeshAgent.isStopped = false;
                Animator.SetInteger("Walk", 1);

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
    }
}
