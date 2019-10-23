using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Dev
{
    public class DevToggler : MonoBehaviour
    {
        [SerializeField]
        private Toggle _devConsoleTogger;

        private void Awake()
        {
            var state = PlayerPrefs.GetInt("devConsole");

            if (state == 1)
            {
                _devConsoleTogger.isOn = true;
            }
            else
            {
                _devConsoleTogger.isOn = false;
            }
        }

        public void SaveDevConsoleState()
        {
            if (_devConsoleTogger.isOn)
            {
                PlayerPrefs.SetInt("devConsole", 1);
            }
            else
            {
                PlayerPrefs.SetInt("devConsole", 0);
            }
        }
    }
}
