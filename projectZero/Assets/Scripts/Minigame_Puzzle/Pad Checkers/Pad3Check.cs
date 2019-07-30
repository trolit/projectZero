using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad3Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock03")
            {
                Debug.Log("Ustawiam Pad3 na true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad3Result = true;

                enabled = false;
            }
            else
            {
                Pad3Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad3Result = false;
        }
    }
}
