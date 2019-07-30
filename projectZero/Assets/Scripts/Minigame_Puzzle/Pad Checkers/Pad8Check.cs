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
                Debug.Log("Ustawiam Pad8 na true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad8Result = true;
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

        void Update()
        {
            if (GameFinished)
            {
                enabled = false;
            }
        }
    }
}
