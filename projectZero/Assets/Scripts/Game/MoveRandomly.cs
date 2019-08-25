using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    public class MoveRandomly : MonoBehaviour
    {
        public float Timer;

        public int NewTarget;

        public NavMeshAgent Nav;

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
            float x = gameObject.transform.position.x;
            float z = gameObject.transform.position.z;

            float xPos = Random.Range(MinX, MaxX);
            float zPos = Random.Range(MinZ, MaxZ);

            Target = new Vector3(xPos, gameObject.transform.position.y, zPos);

            Nav.SetDestination(Target);
        }
    }
}
