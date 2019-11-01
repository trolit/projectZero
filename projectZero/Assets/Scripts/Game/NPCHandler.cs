using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Game
{
    // Use Sphere Collider for speaking range (as trigger)
    // Use Box Collider for "body block"

    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(BoxCollider))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class NPCHandler : MoveRandomlyAdvanced
    {
        [SerializeField]
        [Tooltip("Level required to be able to start conversation.")]
        private int _requiredLevel;

        [SerializeField]
        [Tooltip("Stores question mark which appears above NPC.")]
        private GameObject QuestionSign;

        [SerializeField]
        [Tooltip("Pass language key to access player's level.")]
        private string _languageKey = "csharp";

        [SerializeField]
        [Tooltip("Pass level key in order to check whether it was already done.")]
        private string _levelKey = "Puzzle_C#_1";

        [SerializeField]
        private Dialogue Dialogue;

        public static bool IsPlayerInDialogueArea = false;

        public static bool IsDuringConveration = false;

        private Vector3 _playerVector3;

        private bool _isLevelPlayable = false;

        private new void Start()
        {
            base.Start();
            
            VerifyPlayerSkill();
            
            CheckIfLevelWasCompleted();
        }

        private new void Update()
        {
            base.Update();
           
            if (Input.GetKeyDown(KeyCode.F) && IsPlayerInDialogueArea == true &&
                IsDuringConveration == false && _isLevelPlayable == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(Dialogue);

                IsDuringConveration = true;

                NavMeshAgent.isStopped = true;

                Animator.SetInteger("Walk", 0);

                FaceTarget(_playerVector3);
            }
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
            var lookPos = destination - transform.position;

            lookPos.y = 0;

            Quaternion rotation = Quaternion.LookRotation(lookPos);

            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 10f);
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

        private void VerifyPlayerSkill()
        {
            var playerSkill = PlayerPrefs.GetInt(_languageKey);

            if (playerSkill < _requiredLevel)
            {
                QuestionSign.SetActive(false);

                _isLevelPlayable = false;
            }
            else
            {
                _isLevelPlayable = true;
            }
        }

        private void CheckIfLevelWasCompleted()
        {
            var levelStatus = PlayerPrefs.GetInt(_levelKey + "passed");

            if (levelStatus == 1)
            {
                QuestionSign.SetActive(false);

                _isLevelPlayable = false;
            }
            else
            {
                _isLevelPlayable = true;
            }
        }
    }
}
