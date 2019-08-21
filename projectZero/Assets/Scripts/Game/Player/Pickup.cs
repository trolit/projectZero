using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class Pickup : MonoBehaviour
    {
        private GameObject _player;

        private GameObject _collidedObject;

        private int _carryFlag = 0;

        void Start()
        {
            _player = GameObject.FindWithTag("Player");
        }

        void LateUpdate()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (_carryFlag == 1)
                {
                    var objCollider = _collidedObject.GetComponent<BoxCollider>();

                    if (objCollider != null)
                    {
                        objCollider.enabled = true;
                    }
                    _carryFlag = 0;
                }
            }
        }

        void OnCollisionStay(Collision block)
        {
            if (block.gameObject.tag == "Draggable"
                && Input.GetKey(KeyCode.Space))
            {
                if (_carryFlag == 0)
                {
                    _collidedObject = block.gameObject;
                    block.collider.enabled = false;
                    block.transform.parent = _player.transform;
                    _carryFlag = 1;
                }
            }
            else
            {
                block.transform.parent = null;
            }
        }

        void OnCollisionExit(Collision block)
        {
            block.transform.parent = null;
        }
    }
}
