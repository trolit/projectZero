using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad2Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock02")
            {
                Debug.Log("Setting Pad2 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad2Result = true;

                enabled = false;
            }
            else
            {
                Pad2Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            // If leaf is active and by mistake
            // block will go outside the puzzle
            // area - prevent from changing result
            // to false
            if (!_leaf.activeInHierarchy)
            {
                Pad2Result = false;
            }
        }
    }
}
