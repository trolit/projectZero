using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // Class designed for MoveRandomly scripts including AT LEAST two STATES

    // Warning: Animator needs to contain Walk parameter
    // of type Integer where value 0 means for example
    // Idle and value 1 means Walk

    public class MoveRandomlyAdvanced : MoveRandomlyBase
    {
        [SerializeField]
        [Tooltip("Specifies time when another state should be randomized.")]
        protected float TimeForNewState;

        // enables/disables TimeRandomizer method
        [SerializeField]
        [Tooltip("Enable this to randomize states between min and max value.")]
        protected bool RandomTimeForNewState = false;

        protected Animator Animator;

        [SerializeField]
        [Tooltip("Overwrite this only when random time for new state is set on true.")]
        protected float MinTime = 5f;

        [SerializeField]
        [Tooltip("Overwrite this only when random time for new state is set on true.")]
        protected float MaxTime = 20f;

        protected virtual void Start()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();

            Animator = GetComponent<Animator>();

            if (Animator == null)
            {
                Debug.LogError($"Object {gameObject.name} does NOT contain REQUIRED Animator component!");

                Debug.Break();
            }

            GetNewPath();

            Animator.SetInteger("Walk", 1);
        }

        protected virtual void Update()
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

        protected virtual IEnumerator DoSomething()
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
                    //Debug.Log("Path not reachable !");
                    //Debug.Log("Coordinates: (X - " + NavMeshAgent.destination.x + ")" +
                    //          " (Z - " + NavMeshAgent.destination.z + ")");

                    yield return new WaitForSeconds(0.01f);

                    GetNewPath();
                }
            }

            InCoRoutine = false;
        }
    }
}
