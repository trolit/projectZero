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
        private string productKey;

        [SerializeField]
        private Button _button;

        // Update is called once per frame
        void Update()
        {
            var bookStatus = PlayerPrefs.GetInt(productKey);
           
            if (bookStatus != 1)
            {
                // przycisk interactable na false
                _button.interactable = false;
            }
            else
            {
                _button.interactable = true;
            }
        }
    }
}
    



