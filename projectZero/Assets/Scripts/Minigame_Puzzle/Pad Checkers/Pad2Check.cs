using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    [Obsolete("THIS SCRIPT IS NO LONGER USED IN GAME")]
    public class Pad2Check : Verify_3X3
    {
        private void Start()
        {
            Debug.LogError(
                "Script is obsolete and will be deleted in further commit. Make sure to use PadChecker instead.");
            Debug.Break();
        }

        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block02")
            {
                Debug.Log("Setting Pad2 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad2Result = true;

                enabled = false;
            }
        }
    }
}
