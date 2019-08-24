using UnityEngine;

namespace Assets.Scripts.Minigame_Puzzle
{
    public class TransferMoney : MonoBehaviour
    {
        public void TransferMoneyOnPlayerAccount(int amount)
        {
            var currentMoney = PlayerPrefs.GetInt("money");

            var newMoneyState = currentMoney + amount;

            PlayerPrefs.SetInt("money",
                newMoneyState);
        }
    }
}
