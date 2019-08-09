using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class PinCheck : MonoBehaviour
    {
        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == "ForestBlock02")
            {
                Debug.Log("Wybrano prawidlowy blok!");

                block.gameObject.tag = "UnDraggable";

                enabled = false;
            }
            else
            {
                
            }
        }

        void OnCollisionExit(Collision block)
        {

        }
    }
}
