﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game
{
    [RequireComponent(typeof(SphereCollider))]
    public class NPCHandler : MoveRandomlyAdvanced
    {
        public Dialogue Dialogue;

        public static bool IsPlayerInDialogueArea = false;

        public static bool IsDuringConveration = false;

        private Vector3 _playerVector3;

        private new void Update()
        {
            base.Update();

            if (Input.GetKeyDown(KeyCode.F) && IsPlayerInDialogueArea == true && IsDuringConveration == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(Dialogue);

                IsDuringConveration = true;

                NavMeshAgent.isStopped = true;

                Animator.SetInteger("Walk", 0);

                FaceTarget(_playerVector3);
            }

            Debug.Log(IsDuringConveration + " is during conv");
        }

        protected new IEnumerator DoSomething()
        {
            InCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewState);

            if (IsDuringConveration == false)
            {
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
            }
            else if (IsDuringConveration == true)
            {
                Animator.SetInteger("Walk", 0);
            }

            InCoRoutine = false;
        }

        private void FaceTarget(Vector3 destination)
        {
            Vector3 lookPos = destination - transform.position;
            lookPos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 3f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                IsPlayerInDialogueArea = true;

                _playerVector3 = other.transform.position;

                Debug.Log("Player went in area of conversation!");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                IsPlayerInDialogueArea = false;

                Debug.Log("Player went out of conversation area!");
            }
        }
    }
}
