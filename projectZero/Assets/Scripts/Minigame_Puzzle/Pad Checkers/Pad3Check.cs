using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad3Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block03")
            {
                Debug.Log("Setting Pad3 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad3Result = true;

                enabled = false;
            }
        }
    }
}
