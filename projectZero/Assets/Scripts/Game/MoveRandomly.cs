using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS ONLY MOVEMENT ANIMATION
    [RequireComponent(typeof(NavMeshAgent))]
    public class MoveRandomly : MonoBehaviour
    {
        public float TimeForNewPath;
        public float XValue; 
        public float ZValue;

        private NavMeshAgent _navMeshAgent;
        private bool _inCoRoutine;
        private Vector3 _target;

        // Use this for initialization
        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();

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
            yield return new WaitForSeconds(TimeForNewPath);

            GetNewPath();

            while (_navMeshAgent.pathPending == false)
            {
                Debug.Log("Path not reachable !");
                Debug.Log("Coordinates: (X - " + _navMeshAgent.destination.x + ")" +
                          " (Z - " + _navMeshAgent.destination.z + ")");

                yield return new WaitForSeconds(0.01f);

                GetNewPath();
            }

            _inCoRoutine = false;
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

