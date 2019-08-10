using Assets.Scripts.Camera;
using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class VerifySection : MonoBehaviour
    {
        [SerializeField]
        private GameObject _sectionObject;

        [SerializeField]
        private GameObject _pinModel;

        [SerializeField]
        private GameObject _groundObject;

        [SerializeField]
        private Transform _cameraCurrentPosition;

        [SerializeField]
        private float _cameraNewPosition;

        void OnCollisionEnter(Collision player)
        {
            if (player.gameObject.tag == "Player")
            {
                if (PinCheck.IsCorrect)
                {
                    _sectionObject.SetActive(false);
                    _pinModel.SetActive(false);
                    _groundObject.SetActive(false);

                    _cameraCurrentPosition.GetComponent<TopDown_Camera>().Height
                        = _cameraNewPosition;

                    PinCheck.IsCorrect = false;
                }
            }
        }
    }
}
