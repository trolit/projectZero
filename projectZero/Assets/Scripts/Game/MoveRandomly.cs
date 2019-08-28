using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    public class MoveRandomly : MonoBehaviour
    {
        public float Timer;

        // Frequency of FindNewTarget()
        public int NewTarget;

        // Reference 
        public NavMeshAgent Nav;

        // Stores randomized position
        public Vector3 Target;

        public int MinX;

        public int MaxX;

        public int MinZ;

        public int MaxZ;

        // Start is called before the first frame update
        void Start()
        {
            Nav = gameObject.GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            Timer += Time.deltaTime;

            if (Timer >= NewTarget)
            {
                FindNewTarget();

                Timer = 0;
            }
        }

        void FindNewTarget()
        {
            // Temporarily disabled
            float x = gameObject.transform.position.x;
            float z = gameObject.transform.position.z;

            float xPos = x + Random.Range(x - MinX, x + MaxX);
            float zPos = z + Random.Range(z - MinZ, z + MaxZ);

            Target = new Vector3(xPos, gameObject.transform.position.y, zPos);

            Nav.SetDestination(Target);
        }
    }
}
