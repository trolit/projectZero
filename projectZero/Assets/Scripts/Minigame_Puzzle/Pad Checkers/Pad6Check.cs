using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad6Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock06")
            {
                Debug.Log("Ustawiam Pad6 na true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad6Result = true;
            }
            else
            {
                Pad6Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad6Result = false;
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
