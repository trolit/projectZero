using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad2Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block02")
            {
                Debug.Log("Setting Pad2 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad2Result = true;

                enabled = false;
            }
        }
    }
}
