using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad3Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "Block03")
            {
                Debug.Log("Setting Pad3 on true!");

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

        private void OnCollisionExit(Collision block)
        {
            if (!_leaf.activeInHierarchy)
            {
                Pad3Result = false;
            }
        }
    }
}
