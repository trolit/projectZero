using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class TextShower : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        [SerializeField]
        private GameObject _image;

        [SerializeField]
        private string _description;

        public void DisplayText()
        {
            if (string.IsNullOrEmpty(_description))
            {
                Debug.Log("Żaden tekst nie został wprowadzony do obiektu => " + _text);
            }

            _text.text = _description;

            _image.SetActive(true);

            // run HideText function after 1.5 seconds
            Invoke("HideText", 1.5f);
        }

        public void HideText()
        {
            _text.text = "";

            _image.SetActive(false);
        }
    }
}
