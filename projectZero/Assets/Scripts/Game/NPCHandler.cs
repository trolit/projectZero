using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

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
        [Tooltip("Type language key to access player's level.")]
        private string _languageKey = "csharp";

        [SerializeField]
        [Tooltip("Type mini-game scene name to load.")]
        private string _sceneToLoadName = "Puzzle_C#_1";

        [SerializeField]
        [Tooltip("Type mini-game scene key.")]
        private string _sceneKey = "PU_C#1";

        [SerializeField]
        [Tooltip("Stores avatar that will appear in dialogue placeholder.")]
        private Texture _npcAvatar;

        [SerializeField]
        [Tooltip("Stores reference to avatar placeholder in dialogue.")]
        private RawImage _npcAvatarPlaceHolder;

        [SerializeField]
        [Tooltip("Stores empire avatar that will appear in dialogue placeholder.")]
        private Texture _empireAvatar;

        [SerializeField]
        [Tooltip("Include empire image (example: csharp icon).")]
        private RawImage _empirePlaceHolder;

        [SerializeField]
        private Dialogue Dialogue;

        public static bool IsPlayerInDialogueArea = false;

        public static bool IsDuringConveration = false;

        public static string SceneToLoadName;

        private Vector3 _playerVector3;

        private bool _isLevelPlayable = false;

        private bool _isLevelCompleted = false;

        private new void Start()
        {
            base.Start();

            SceneToLoadName = _sceneToLoadName;

            VerifyPlayerSkill();
            
            CheckIfLevelWasCompleted();
        }

        private new void Update()
        {
            base.Update();

            if (Input.GetKeyDown(KeyCode.F) && IsPlayerInDialogueArea == true &&
                IsDuringConveration == false && _isLevelPlayable == true)
            {
                _npcAvatarPlaceHolder.texture = _npcAvatar;

                _empirePlaceHolder.texture = _empireAvatar;

                FindObjectOfType<DialogueManager>().StartDialogue(Dialogue);

                IsDuringConveration = true;

                NavMeshAgent.isStopped = true;

                Animator.SetInteger("Walk", 0);

                FaceTarget(_playerVector3);
            }

            Debug.Log("Is During Conv => " + IsDuringConveration);

            // If level is not currently playable and level is not completed
            // verify player skill
            if (_isLevelPlayable == false && _isLevelCompleted == false)
            {
                VerifyPlayerSkill();
            }
        }

        protected override IEnumerator DoSomething()
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
            var levelStatus = PlayerPrefs.GetInt(_sceneKey + "passed");

            if (levelStatus == 1)
            {
                QuestionSign.SetActive(false);

                _isLevelCompleted = true;
            }
        }
    }
}
