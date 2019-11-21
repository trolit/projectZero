using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle.Pad_Checkers
{
    public class Pad6Check : Verify_3X3
    {
        [SerializeField]
        private GameObject _leaf;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Block06")
            {
                Debug.Log("Setting Pad6 on true!");

                _leaf.SetActive(true);

                other.gameObject.tag = "UnDraggable";

                Pad6Result = true;

                enabled = false;
            }
        }
    }
}
