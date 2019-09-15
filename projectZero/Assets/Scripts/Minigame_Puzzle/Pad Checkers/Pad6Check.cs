using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad6Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "Block06")
            {
                Debug.Log("Setting Pad6 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad6Result = true;

                enabled = false;
            }
            else
            {
                Pad6Result = false;
            }
        }

        void OnCollisionExit(Collision block)
        {
            if (!_leaf.activeInHierarchy)
            {
                Pad6Result = false;
            }
        }
    }
}
