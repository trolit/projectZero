using System.Collections.Generic;
using Assets.Scripts.Camera;
using UnityEngine;

namespace Assets.Scripts.Minigame_Skyscraper
{
    public class CorrectAnswer : Answer
    {
        [SerializeField]
        private List<GameObject> _objectsToHide;

        [SerializeField]
        private Transform _cameraCurrentPosition;

        [SerializeField]
        private float _cameraNewPosition;

        private void Update()
        {
            if (IsOnQuestion)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // Debug.Log("Clip name => " + Clip.name);
                    Source.PlayOneShot(Clip);

                    foreach (var _object in _objectsToHide)
                    {
                        _object.SetActive(false);
                    }

                    _cameraCurrentPosition.GetComponent<TopDown_Camera>().Height
                        = _cameraNewPosition;
                }
            }
        }
    }
}
