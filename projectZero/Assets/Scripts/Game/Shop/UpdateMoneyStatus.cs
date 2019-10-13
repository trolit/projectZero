using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Shop
{
    public class UpdateMoneyStatus : MonoBehaviour
    {
        [SerializeField]
        private Text _currentMoneyText;

        private void Update()
        {
            var money = PlayerPrefs.GetInt("money");

            _currentMoneyText.text = money.ToString();
        }
    }
}
