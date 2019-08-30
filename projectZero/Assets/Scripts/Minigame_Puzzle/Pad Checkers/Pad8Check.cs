using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad8Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock08")
            {
                Debug.Log("Setting Pa8 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad8Result = true;

                enabled = false;
            }
            else
            {
                Pad8Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad8Result = false;
        }
    }
}
