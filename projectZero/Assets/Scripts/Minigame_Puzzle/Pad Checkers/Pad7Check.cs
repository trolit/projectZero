using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad7Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block07")
            {
                Debug.Log("Setting Pad7 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad7Result = true;

                enabled = false;
            }
        }
    }
}
