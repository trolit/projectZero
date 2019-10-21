using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    [RequireComponent(typeof(OnHoverTextChanger))]
    [RequireComponent(typeof(StrapColorChanger))]
    public class CheckGameStatus : MonoBehaviour
    {
        [SerializeField]
        private Button _continueButton;

        [SerializeField]
        private GameObject _lockImage;

        [SerializeField]
        private Text _buttonText;

        private void Awake()
        {
            var value = PlayerPrefs.GetInt("newgame");

            if (value == 1)
            {
                _continueButton.gameObject.SetActive(true);

                _lockImage.SetActive(false);

                _buttonText.color = new Color32(255, 255, 255, 255);
            }
            else
            {
                _continueButton.interactable = false;

                _lockImage.SetActive(true);

                GetComponent<OnHoverTextChanger>().enabled = false;

                GetComponent<StrapColorChanger>().enabled = false;

                _buttonText.color = new Color32(255,255,255, 82);
            }
        }
    }
}
