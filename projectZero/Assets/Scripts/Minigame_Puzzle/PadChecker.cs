using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle
{
    public class PadChecker : MonoBehaviour
    {
        [SerializeField]
        private GameObject _padSuccessGameObject;

        [Tooltip("Set object name of block that should be placed in the area that holds this script.")]
        [SerializeField]
        private string _validBlockName;

        private void Start()
        {
            if (_validBlockName.ToLower() == "mark_as_valid")
            {
                PuzzleManager.PuzzleStatus++;

                _padSuccessGameObject.SetActive(true);

                enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(_validBlockName))
            {
                Debug.LogError("No valid block name specified! Property cannot be null or whitespace!");
                Debug.Break();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == _validBlockName)
            {
                _padSuccessGameObject.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                PuzzleManager.PuzzleStatus++;

                enabled = false;
            }
        }
    }
}
