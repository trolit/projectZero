using Assets.Scripts.Game;
using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle
{
    public class PuzzleManager : MonoBehaviour
    {
        public static int PuzzleStatus;

        [Tooltip("Define how many puzzles are set in level. Value must be greater than 0.")]
        [SerializeField]
        private int _puzzleAmount;

        private void Start()
        {
            if (_puzzleAmount <= 0)
            {
                Debug.LogError("_puzzleAmount value cannot be less/equal than 0");
                Debug.Break();
            }

            PuzzleStatus = 0;
        }

        private void Update()
        {
            if (PuzzleStatus >= _puzzleAmount)
            {
                TriggerWin();
            }
        }

        private void TriggerWin()
        {
            var script = GetComponent<WinScript>();

            script.enabled = true;

            // Turn off Update()
            enabled = false;
        }
    }
}
