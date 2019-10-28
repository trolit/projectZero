using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class KnightSetter : MonoBehaviour
    {
        [SerializeField]
        private GameObject _helmet01;

        [SerializeField]
        private GameObject _helmet02;

        [SerializeField]
        private GameObject _helmet03;

        [SerializeField]
        private GameObject _shoulders;

        private void Start()
        {
            var pickedHelmetValue = PlayerPrefs.GetInt("knightHelmet");

            if (pickedHelmetValue == 1)
            {
                _helmet02.SetActive(true);
            }
            else if (pickedHelmetValue == 2)
            {
                _helmet03.SetActive(true);
            }
            else
            {
                Debug.Log("Default helmet equipped!");
                _helmet01.SetActive(true);
            }

            var shouldersValue = PlayerPrefs.GetInt("knightShoulders");

            if (shouldersValue == 0)
            {
                _shoulders.SetActive(true);
            }
            else
            {
                _shoulders.SetActive(false);
            }
        }
    }
}
