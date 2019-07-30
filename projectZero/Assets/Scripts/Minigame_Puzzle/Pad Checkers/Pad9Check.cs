using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad9Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock09")
            {
                Debug.Log("Ustawiam Pad9 na true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad9Result = true;
            }
            else
            {
                Pad9Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            Pad9Result = false;
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
