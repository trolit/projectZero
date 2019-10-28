using Assets.Scripts.Camera;
using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class VerifySection : MonoBehaviour
    {
        /*          Pads reference             */

        [SerializeField]
        private GameObject _block01;

        [SerializeField]
        private GameObject _block02;

        [SerializeField]
        private GameObject _block03;

        /* *********************************** */


        /* Sound effects & ref to audio source */

        [SerializeField]
        private AudioSource _sfxAudioSource;

        [SerializeField]
        private AudioClip _correctClip;

        [SerializeField]
        private AudioClip _wrongClip;

        /* *********************************** */

        [SerializeField]
        private GameObject _sectionObject;

        [SerializeField]
        private GameObject _pinModel;

        [SerializeField]
        private GameObject _groundObject;

        [SerializeField]
        private GameObject _buttonObject;

        [SerializeField]
        private Transform _cameraCurrentPosition;

        [SerializeField]
        private float _cameraNewPosition;

        /* *********************************** */

        private bool _isActivated;

        private void OnCollisionEnter(Collision player)
        {
            if (player.gameObject.tag == "Player"
                && _isActivated == false)
            {
                _isActivated = true;

                if (PinCheck.IsCorrect)
                {
                    _block01.SetActive(false);
                    _block02.SetActive(false);
                    _block03.SetActive(false);

                    _sectionObject.SetActive(false);
                    _pinModel.SetActive(false);
                    _groundObject.SetActive(false);
                    _buttonObject.SetActive(false);

                    _sfxAudioSource.PlayOneShot(_correctClip);

                    _cameraCurrentPosition.GetComponent<TopDown_Camera>().Height
                        = _cameraNewPosition;

                    PinCheck.IsCorrect = false;
                }
                else
                {
                    _sfxAudioSource.PlayOneShot(_wrongClip);

                    PinCheck.MistakesAmount++;

                    // Debug.Log("Liczba bledow => " + PinCheck.MistakesAmount);
                }

                Invoke("ResetButton", 1.5f);
            }
        }

        private void ResetButton()
        {
            _isActivated = false;
        }
    }
}
