using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class TextShower : MonoBehaviour
    {
        [SerializeField]
        private Text Text;

        [SerializeField]
        private string Description;

        public void DisplayText()
        {
            if (string.IsNullOrEmpty(Description))
            {
                Debug.Log("Żaden tekst nie został wprowadzony do obiektu => " + Text);
            }

            Text.text = Description;

            // run HideText function after 1.5 seconds
            Invoke("HideText", 1.5f);
        }

        public void HideText()
        {
            Text.text = "";
        }
    }
}
