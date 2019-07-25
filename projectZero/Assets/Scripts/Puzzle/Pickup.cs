using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle
{
    public class Pickup : MonoBehaviour
    {
        private GameObject _player;

        void Start()
        {
            _player = GameObject.FindWithTag("Player");
        }

        void OnCollisionStay(Collision block)
        {
            if (block.gameObject.tag == "Draggable"
                && Input.GetKey(KeyCode.F))
            {
                // block.collider.enabled = false;
                block.transform.parent = _player.transform;
            }
            else
            {
                block.transform.parent = null;
            }
        }
    }
}
