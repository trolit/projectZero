using Assets.Scripts.Game;
using EasyButtons;
using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle
{
    public class PuzzleManager : MonoBehaviour
    {
        [Button]
        public void CheckCurrentGameState()
        {
            Debug.Log($"<b>{PuzzleStatus}</b> out of <b>{_puzzleAmount}</b> blocks are placed correctly.");
        }

        [Button]
        public void TriggerWinManually()
        {
            TriggerWin();
        }

        public static int PuzzleStatus;

        [Tooltip("Define how many puzzles are set in level. Value must be greater than 0.")]
        [SerializeField]
        private int _puzzleAmount;

        private void Awake()
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
