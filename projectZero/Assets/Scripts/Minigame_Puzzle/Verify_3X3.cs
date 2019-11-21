using Assets.Scripts.Game;
using EasyButtons;
using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle
{
    public class Verify_3X3 : MonoBehaviour
    {
        [Button]
        public void CheckPadsStates()
        {
            Debug.Log("Pad2 => " + Pad2Result);
            Debug.Log("Pad3 => " + Pad3Result);
            Debug.Log("Pad4 => " + Pad4Result);
            Debug.Log("Pad5 => " + Pad5Result);
            Debug.Log("Pad6 => " + Pad6Result);
            Debug.Log("Pad7 => " + Pad7Result);
            Debug.Log("Pad8 => " + Pad8Result);
            Debug.Log("Pad9 => " + Pad9Result);
        }

        protected static bool Pad2Result;

        protected static bool Pad3Result;

        protected static bool Pad4Result;

        protected static bool Pad5Result;

        protected static bool Pad6Result;

        protected static bool Pad7Result;

        protected static bool Pad8Result;

        protected static bool Pad9Result;

        [SerializeField]
        private string _command;

        // Set all to false
        // Awake RUNS BEFORE Start
        private void Awake()
        {
            Pad2Result = false;
            Pad3Result = false;
            Pad4Result = false;
            Pad5Result = false;
            Pad6Result = false;
            Pad7Result = false;
            Pad8Result = false;
            Pad9Result = false;
        }

        // If some puzzles need to have already marked as true elements
        // SET them here
        private void Start()
        {
            if (_command.Contains("Pad4True"))
            {
                Pad4Result = true;
            }

            if (_command.Contains("Pad9True"))
            {
                Pad9Result = true;
            }

            if (_command.Contains("Pad8True"))
            {
                Pad8Result = true;
            }
        }

        private void Update()
        {
            if (Pad2Result && Pad3Result && Pad4Result
                && Pad5Result && Pad6Result && Pad7Result
                && Pad8Result && Pad9Result)
            {
                var script = GetComponent<WinScript>();

                script.enabled = true;

                // Turn off Update()
                enabled = false;
            }
        }
    }
}
