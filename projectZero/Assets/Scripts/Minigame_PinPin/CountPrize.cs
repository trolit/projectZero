using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Minigame_PinPin
{
    public class CountPrize : MonoBehaviour
    {
        [SerializeField]
        private Text _prizeText;

        [SerializeField]
        private int _startingPrize = 250;

        private int _prize = 0;

        private void Awake()
        {
            _prize = _startingPrize - PinCheck.MistakesAmount * 20;

            if (_prize < 0)
            {
                _prize = 0;
            }

            _prizeText.text = _prize.ToString();
        }

        public void SendMoney()
        {
            var currentMoney = PlayerPrefs.GetInt("money");

            PlayerPrefs.SetInt("money", currentMoney + _prize);
        }
    }
}
