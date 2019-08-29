﻿using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class MoveRandomly : MonoBehaviour
    {
        public float TimeForNewPath;
        public float MinX;
        public float MaxX;
        public float MinZ;
        public float MaxZ;

        NavMeshAgent _navMeshAgent;
        NavMeshPath _path;
        bool _inCoRoutine;
        Vector3 _target;
        bool _validPath;

        // Use this for initialization
        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _path = new NavMeshPath();

            GetNewPath();
        }

        // Update is called once per frame
        private void Update()
        {
            if (_inCoRoutine == false)
                StartCoroutine(DoSomething());
        }

        private Vector3 GetNewRandomPosition()
        {
            float currentX = transform.position.x;
            float currentZ = transform.position.z;

            // setting these ranges is vital larger seems better 
            float x = currentX + Random.Range(currentX - MinX, currentX + MaxX);

            float z = currentZ + Random.Range(currentZ - MinZ, currentZ + MaxZ);

            Vector3 pos = new Vector3(x, transform.position.y, z);

            return pos;
        }

        private IEnumerator DoSomething()
        {
            _inCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewPath);

            GetNewPath();
            _validPath = _navMeshAgent.CalculatePath(_target, _path);

            if (!_validPath)
                Debug.Log("Found invalid path! Finding new one...");

            while (!_validPath)
            {
                yield return new WaitForSeconds(0.01f);

                GetNewPath();

                _validPath = _navMeshAgent.CalculatePath(_target, _path);
            }

            _inCoRoutine = false;
        }

        private void GetNewPath()
        {
            _target = GetNewRandomPosition();
            _navMeshAgent.SetDestination(_target);
        }
    }
}
