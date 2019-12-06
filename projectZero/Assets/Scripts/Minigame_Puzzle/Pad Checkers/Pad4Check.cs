using System;
using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    [Obsolete("THIS SCRIPT IS NO LONGER USED IN GAME")]
    public class Pad4Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void Start()
        {
            Debug.LogError(
                "Script is obsolete and will be deleted in further commit. Make sure to use PadChecker instead.");
            Debug.Break();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block04")
            {
                Debug.Log("Setting Pad4 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad4Result = true;

                enabled = false;
            }
        }
    }
}
