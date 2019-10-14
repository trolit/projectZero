using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Minigame_Skyscraper
{
    public class SkyscraperPrizeManager : MonoBehaviour
    {
        [SerializeField]
        private Text _prizeText;

        public static int MistakesCount = 0;

        private int _prize;

        public void TransferMoney()
        {
            if (_prize < 0)
            {
                _prize = 0;
            }

            var currentMoney = PlayerPrefs.GetInt("money");

            var newMoney = currentMoney + _prize;

            PlayerPrefs.SetInt("money", newMoney);
        }

        private int CountSkyscraperPrize()
        {
            return 250 - (MistakesCount * 15);
        }

        private void Awake()
        {
            _prize = CountSkyscraperPrize();

            _prizeText.text = _prize.ToString();
        }
    }
}
