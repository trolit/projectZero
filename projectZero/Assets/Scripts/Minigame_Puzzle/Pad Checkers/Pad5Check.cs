using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad5Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock05")
            {
                Debug.Log("Setting Pad5 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad5Result = true;

                enabled = false;
            }
            else
            {
                Pad5Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            if (!_leaf.activeInHierarchy)
            {
                Pad5Result = false;
            }
        }
    }
}
