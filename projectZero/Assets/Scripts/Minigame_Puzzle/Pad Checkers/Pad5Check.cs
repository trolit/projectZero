using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad5Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block05")
            {
                Debug.Log("Setting Pad5 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad5Result = true;

                enabled = false;
            }
        }
    }
}
