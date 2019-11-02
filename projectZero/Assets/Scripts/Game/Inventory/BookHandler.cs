using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Inventory
{
    public class BookHandler : MonoBehaviour
    {
        [SerializeField]
        private string _bookKey;

        [SerializeField]
        private Button _button;

        // Update is called once per frame
        private void Update()
        {
            var bookStatus = PlayerPrefs.GetInt(_bookKey);
           
            if (bookStatus != 1) // if the book has not been bought yet
            {
                _button.interactable = false;
            }
            else
            {
                _button.interactable = true;
            }
        }
    }
}
    



