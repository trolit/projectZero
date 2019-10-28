using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // Class designed for MoveRandomly scripts including MAX one STATE

    [RequireComponent(typeof(NavMeshAgent))]
    public class MoveRandomlyBase : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Specifies time when another path should be set.")]
        protected float TimeForNewPath;

        [SerializeField]
        [Tooltip("Specifies X axis range for path randomization.")]
        protected float XValue;

        [SerializeField]
        [Tooltip("Specifies Z axis range for path randomization.")]
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

        protected int StateRandomizer()
        {
            // Returns 0 or 1 
            var result = Random.Range(0, 2);

            return result;
        }

        protected float TimeRandomizer(float min, float max)
        {
            var result = Random.Range(min, max);

            return result;
        }
    }
}
