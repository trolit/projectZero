using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class CheckGameStatus : MonoBehaviour
    {
        [SerializeField]
        private Button _continueButton;

        void Awake()
        {
            int value = PlayerPrefs.GetInt("newgame");

            if (value == 1)
            {
                _continueButton.gameObject.SetActive(true);
            }
            else
            {
                _continueButton.gameObject.SetActive(false);
            }
        }
    }
}
