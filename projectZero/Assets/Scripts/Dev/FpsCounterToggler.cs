using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Dev
{
    public class FpsCounterToggler : MonoBehaviour
    {
        string _label = "";
        float _count;

        private bool _isEnabled = false;

        [SerializeField]
        private int _x = 5;

        [SerializeField]
        private int _y = 40;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                _isEnabled = !_isEnabled;

                if (_isEnabled == true)
                {
                    StartCoroutine(ToggleCounter());
                }
                else if (_isEnabled == false)
                {
                    StopCoroutine(ToggleCounter());
                }
            }
        }

        private IEnumerator ToggleCounter()
        {
            GUI.depth = 2;
            while (true)
            {
                if (Time.timeScale >= 1)
                {
                    yield return new WaitForSeconds(0.1f);
                    _count = (1 / Time.deltaTime);
                    _label = "<size=30><color=yellow> FPS :" + (Mathf.Round(_count)) + "</color></size>";
                }
                else
                {
                    _label = "Pause";
                }
                yield return new WaitForSeconds(0.5f);
            }
        }

        private void OnGUI()
        {
            if (_isEnabled)
            {
                GUI.Label(new Rect(_x, _y, 200, 50), _label);
            }
            else if (_isEnabled == false)
            {
                GUI.Label(new Rect(_x, _y, 200, 50), "");
            }
        }
    }
}
