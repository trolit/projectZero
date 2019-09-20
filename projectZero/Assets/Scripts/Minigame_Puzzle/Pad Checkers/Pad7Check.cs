﻿using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad7Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "Block07")
            {
                Debug.Log("Setting Pad7 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad7Result = true;

                enabled = false;
            }
            else
            {
                Pad7Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            if (!_leaf.activeInHierarchy)
            {
                Pad7Result = false;
            }
        }
    }
}
