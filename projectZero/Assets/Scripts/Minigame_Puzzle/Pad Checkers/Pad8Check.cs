using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad8Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block08")
            {
                Debug.Log("Setting Pa8 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad8Result = true;

                enabled = false;
            }
            else
            {
                Pad8Result = false;
            }
        }
    }
}
