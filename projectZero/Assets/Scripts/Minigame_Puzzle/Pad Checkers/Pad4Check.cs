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
            Debug.Log(block.gameObject.name);

            if (block.gameObject.name == "ForestBlock04")
            {
                Debug.Log("Ustawiam Pad4 na true!");

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
            Pad4Result = false;
        }

        void Update()
        {
            if (Command == "Pad4True")
            {
                Pad4Result = true;

                enabled = false;
            }
        }
    }
}
