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
            Pad2Result = false;
        }
    }
}
