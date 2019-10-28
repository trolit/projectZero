using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad9Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "Block09")
            {
                Debug.Log("Setting Pad9 on true!");

                _leaf.SetActive(true);

                block.gameObject.tag = "UnDraggable";

                Pad9Result = true;

                enabled = false;
            }
            else
            {
                Pad9Result = false;
            }
        }

        private void OnCollisionExit(Collision block)
        {
            if (!_leaf.activeInHierarchy)
            {
                Pad9Result = false;
            }
        }
    }
}
