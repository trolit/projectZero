using Assets.Scripts.Game;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Minigame_Maze
{
    public class MazeMinigame : MonoBehaviour
    {
        [SerializeField]
        private Text _currentlyPickedText;

        [SerializeField]
        private Text _maxToPickText;

        public static int CurrentlyPicked = 0;

        public static int BugsPicked = 0;

        [SerializeField]
        private int _maxToPick = 6;

        void Start()
        {
            _currentlyPickedText.text = CurrentlyPicked.ToString();
            _maxToPickText.text = _maxToPick.ToString();
        }

        void Update()
        {
            _currentlyPickedText.text = CurrentlyPicked.ToString();

            if (CurrentlyPicked == _maxToPick)
            {
                var script = GetComponent<WinScript>();

                script.enabled = true;

                // Turn off Update()
                enabled = false;
            }
        }
    }
}
