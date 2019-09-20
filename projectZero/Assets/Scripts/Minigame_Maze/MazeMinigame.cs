﻿using Assets.Scripts.Game;
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

        [SerializeField]
        private GameObject _fullSummaryText;

        [SerializeField]
        private GameObject _halfSummaryText;

        [SerializeField]
        private GameObject _quarterSummaryText;

        [SerializeField]
        private Text _moneyText;

        private int _moneyAmount;

        public static int CurrentlyPicked = 0;

        public static int BugsPicked = 0;

        [SerializeField]
        private int _maxToPick = 6;

        void Start()
        {
            CurrentlyPicked = 0;
            BugsPicked = 0;

            _currentlyPickedText.text = CurrentlyPicked.ToString();
            _maxToPickText.text = _maxToPick.ToString();
        }

        void Update()
        {
            _currentlyPickedText.text = CurrentlyPicked.ToString();

            if (CurrentlyPicked == _maxToPick)
            {
                var script = GetComponent<WinScript>();

                if (BugsPicked == 3)
                {
                    _halfSummaryText.SetActive(true);
                }
                else if (BugsPicked > 3)
                {
                    _quarterSummaryText.SetActive(true);
                }
                else
                {
                    _fullSummaryText.SetActive(true);
                }

                _moneyAmount = (250 - (BugsPicked * 20));

                _moneyText.text = _moneyAmount.ToString();

                // Launch script
                script.enabled = true;

                // Turn off Update()
                enabled = false;
            }
        }

        public void TransferMoney()
        {
            var currentMoney = PlayerPrefs.GetInt("money");

            PlayerPrefs.SetInt("money", currentMoney + _moneyAmount);
        }
    }
}
