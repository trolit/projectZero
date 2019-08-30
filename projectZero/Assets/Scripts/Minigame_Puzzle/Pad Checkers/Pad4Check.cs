using System;
using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad4Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock04")
            {
                Debug.Log("Setting Pad4 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad4Result = true;

                enabled = false;
            }
            else
            {
                Pad4Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            if (!_leaf.activeInHierarchy)
            {
                Pad4Result = false;
            }
        }
    }
}
