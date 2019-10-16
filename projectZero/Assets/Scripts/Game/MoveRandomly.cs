using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS ONLY MOVEMENT ANIMATION

    public class MoveRandomly : MoveRandomlyBase
    {
        // Use this for initialization
        private void Start()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();

            GetNewPath();
        }

        // Update is called once per frame
        private void Update()
        {
            if (!InCoRoutine)
                StartCoroutine(DoSomething());
        }

        private IEnumerator DoSomething()
        {
            InCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewPath);

            GetNewPath();

            while (NavMeshAgent.pathPending == false)
            {
                Debug.Log("Path not reachable !");
                Debug.Log("Coordinates: (X - " + NavMeshAgent.destination.x + ")" +
                          " (Z - " + NavMeshAgent.destination.z + ")");

                yield return new WaitForSeconds(0.01f);

                GetNewPath();
            }

            InCoRoutine = false;
        }
    }
}

