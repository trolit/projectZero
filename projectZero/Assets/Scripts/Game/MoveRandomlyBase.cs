using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class MoveRandomlyBase : MonoBehaviour
    {
        [SerializeField]
        protected float TimeForNewPath;

        [SerializeField]
        protected float XValue;

        [SerializeField]
        protected float ZValue;

        protected NavMeshAgent NavMeshAgent;
        protected bool InCoRoutine;
        protected Vector3 Target;

        protected void GetNewPath()
        {
            Target = GetNewRandomPosition();

            NavMeshAgent.SetDestination(Target);
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
