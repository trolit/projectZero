using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class Pickup : MonoBehaviour
    {
        private GameObject _player;

        private GameObject _draggableObject;

        public static bool IsHolding = false;

        private void Start()
        {
            _player = GameObject.FindWithTag("Player");
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (_draggableObject != null)
                {
                    _draggableObject.GetComponent<BoxCollider>().enabled = false;

                    _draggableObject.transform.parent = _player.transform;

                    IsHolding = true;
                }
            }
            else
            {
                if (_draggableObject != null)
                {
                    _draggableObject.GetComponent<BoxCollider>().enabled = true;

                    _draggableObject.transform.parent = null;

                    _draggableObject = null;
                }

                IsHolding = false;
            }
        }

        private void OnCollisionStay(Collision block)
        {
            if (block.gameObject.tag == "Draggable" & IsHolding == false)
            {
                _draggableObject = block.gameObject;
            }
        }
    }
}
