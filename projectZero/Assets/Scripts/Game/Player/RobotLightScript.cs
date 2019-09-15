using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class RobotLightScript : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lightObject;

        // Update is called once per frame
        void Update()
        {
            if (MovementScript.IsMoving)
            {
                _lightObject.SetActive(false);
            }
            else
            {
                _lightObject.SetActive(true);
            }
        }
    }
}
