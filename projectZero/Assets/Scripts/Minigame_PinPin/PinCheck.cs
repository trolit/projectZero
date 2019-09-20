﻿using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class PinCheck : MonoBehaviour
    {
        [SerializeField]
        private string _correctObjectName;

        public static bool IsCorrect = false;

        public static int MistakesAmount = 0;

        [SerializeField]
        private GameObject _verifyButton;

        void Start()
        {
            _verifyButton.SetActive(false);
        }

        void OnCollisionEnter(Collision block)
        {
            Debug.Log("Sprawdzam => " + block.gameObject.name);

            if (block.gameObject.name == _correctObjectName)
            {
                Debug.Log("Wybrano prawidlowy blok!");

                IsCorrect = true;
            }
            else if (block.gameObject.tag == "Wrong")
            {
                Debug.Log("Wybrano nieprawidlowy blok!");

                IsCorrect = false;
            }
            else if (block.gameObject.tag == "Player")
            {
                _verifyButton.SetActive(true);
            }
        }
    }
}
