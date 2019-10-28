using Assets.Scripts.Game;
using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class WinPad : MonoBehaviour
    {
        private void OnCollisionEnter(Collision player)
        {
            if (player.gameObject.tag == "Player")
            {
                var script = GetComponent<WinScript>();

                script.enabled = true;
            }
        }
    }
}
