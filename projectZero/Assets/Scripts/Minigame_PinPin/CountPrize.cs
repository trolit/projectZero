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

        void Awake()
        {
            _prizeText.text = (_startingPrize - (PinCheck.MistakesAmount * 20)).ToString();
        }
    }
}
