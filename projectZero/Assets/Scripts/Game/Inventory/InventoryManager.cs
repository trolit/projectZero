﻿using UnityEngine;

namespace Assets.Scripts.Game.Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _inventoryUi;

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                _inventoryUi.SetActive(!_inventoryUi.activeInHierarchy);

                //if (_inventoryUi.activeInHierarchy)       --> Pausing game makes book pages stuttering :( 
                //{
                //    Time.timeScale = 0f;
                //}
                //else
                //{
                //    Time.timeScale = 1f;
                //}
            }
        }
    }

}

