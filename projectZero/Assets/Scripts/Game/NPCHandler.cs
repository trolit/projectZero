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
        private GameObject _miniMapSign;

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
        private Dialogue _dialogue;

        public static bool IsPlayerInDialogueArea = false;

        public static bool IsDuringConversation = false;

        public static string SceneToLoadName;

        // Used in script TalkSoundHandler to manage
        // from which clip list should be sound played
        public static string Language;

        private Vector3 _playerVector3;

        private bool _isLevelPlayable = false;

        private bool _isLevelCompleted = false;

        // Solution for always talking with the same NPC
        private bool _privateObjectState = false;

        protected override void Start()
        {
            base.Start();

            IsDuringConversation = false;

            VerifyPlayerSkill();
            
            CheckIfLevelWasCompleted();

            RunLevelCounter();
        }

        protected override void Update()
        {
            base.Update();

            if (Input.GetKeyDown(KeyCode.F) && IsPlayerInDialogueArea == true &&
                IsDuringConversation == false && _isLevelPlayable == true &&
                _privateObjectState && _isLevelCompleted == false)
            {
                SceneToLoadName = _sceneToLoadName;

                Language = _languageKey;

                _npcAvatarPlaceHolder.texture = _npcAvatar;

                _empirePlaceHolder.texture = _empireAvatar;

                FindObjectOfType<DialogueManager>().StartDialogue(_dialogue);

                TalkSoundHandler.PlayClipOnConversationStart();

                IsDuringConversation = true;

                NavMeshAgent.isStopped = true;

                Animator.SetInteger("Walk", 0);

                FaceTarget(_playerVector3);
            }

            // If level is not currently playable and level is not completed
            // verify player skill each frame
            if (_isLevelPlayable == false && _isLevelCompleted == false)
            {
                VerifyPlayerSkill();
            }
        }

        protected override IEnumerator DoSomething()
        {
            InCoRoutine = true;
            yield return new WaitForSeconds(TimeForNewState);

            if (IsDuringConversation == false)
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
                        if (Debug.isDebugBuild)
                        {
                            Debug.Log("Path not reachable !");
                            Debug.Log("Coordinates: (X - " + NavMeshAgent.destination.x + ")" +
                                      " (Z - " + NavMeshAgent.destination.z + ")");
                        }

                        yield return new WaitForSeconds(0.01f);

                        GetNewPath();
                    }
                }
            }
            else if (IsDuringConversation == true)
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

                _privateObjectState = true;

                _playerVector3 = other.transform.position;

                if (_isLevelPlayable == true && _isLevelCompleted == false)
                {
                    var interactWithNpcTipState = PlayerPrefs.GetInt("interactNpcTip");

                    if (interactWithNpcTipState == 0)
                    {
                        TipManager.instance.InvokeInteractionWithNpcTip();
                    }
                }

                // Debug.Log("Player went in area of conversation!");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                IsPlayerInDialogueArea = false;

                _privateObjectState = false;

                // Debug.Log("Player went out of conversation area!");
            }
        }

        private void VerifyPlayerSkill()
        {
            var playerSkill = PlayerPrefs.GetInt(_languageKey);

            if (playerSkill < _requiredLevel)
            {
                QuestionSign.SetActive(false);

                _miniMapSign.SetActive(false);

                _isLevelPlayable = false;
            }
            else
            {
                QuestionSign.SetActive(true);

                _miniMapSign.SetActive(true);

                _isLevelPlayable = true;
            }
        }

        private void CheckIfLevelWasCompleted()
        {
            var levelStatus = PlayerPrefs.GetInt(_sceneKey);

            // 1 means level is completed
            if (levelStatus == 1)
            {
                QuestionSign.SetActive(false);

                _miniMapSign.SetActive(false);

                _isLevelCompleted = true;
            }
            else
            {
                _isLevelCompleted = false;
            }
        }

        private void RunLevelCounter()
        {
            switch (_languageKey)
            {
                case "csharp":
                    if (_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.CsharpActive++;
                    else if (!_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.CsharpInActive++;
                    else if (_isLevelCompleted)
                        LevelCounter.instance.CsharpFinished++;
                    break;
                case "java":
                    if (_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.JavaActive++;
                    else if (!_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.JavaInActive++;
                    else if (_isLevelCompleted)
                        LevelCounter.instance.JavaFinished++;
                    break;
                case "html":
                    if (_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.HtmlActive++;
                    else if (!_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.HtmlInActive++;
                    else if (_isLevelCompleted)
                        LevelCounter.instance.HtmlFinished++;
                    break;
                case "php":
                    if (_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.PhpActive++;
                    else if (!_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.PhpInActive++;
                    else if (_isLevelCompleted)
                        LevelCounter.instance.PhpFinished++;
                    break;
                case "javascript":
                    if (_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.JsActive++;
                    else if (!_isLevelPlayable && !_isLevelCompleted)
                        LevelCounter.instance.JsInActive++;
                    else if (_isLevelCompleted)
                        LevelCounter.instance.JsFinished++;
                    break;
                default:
                    Debug.LogError($"Unknown language key on {gameObject.name}, FIX IT!");
                    Debug.Break();
                    break;
            }
        }
    }
}
