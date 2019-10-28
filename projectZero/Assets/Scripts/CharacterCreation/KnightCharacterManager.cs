using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CharacterCreation
{
    public class KnightCharacterManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _knightAdditionalTools;

        [SerializeField]
        private GameObject _shoulders;

        [SerializeField]
        private List<GameObject> _helmets;

        [SerializeField]
        [Tooltip("If set on true, additional personalization will be shown nevertheless medals amount.")]
        private bool _isUnderTest = false;

        public static bool UnderTest;

        private int _index = 0;

        private int _medalsAmount = 0;

        private void Start()
        {
            UnderTest = _isUnderTest;

            if (UnderTest == false)
            {
                _knightAdditionalTools.SetActive(false);
            }

            _medalsAmount = PlayerPrefs.GetInt("medalsUnlocked");

            _helmets[0].SetActive(true);
        }

        public void VerifyMedalsAmount()
        {
            if (_medalsAmount >= 4 || _isUnderTest)
            {
                _knightAdditionalTools.SetActive(true);
            }
        }

        public void ManageShoulders()
        {
            _shoulders.SetActive(!_shoulders.activeInHierarchy);

            SetupCharacterManager.KnightShoulders = 
                _shoulders.activeInHierarchy ? 0 : 1;
        }

        public void ManageHelmet()
        {
            _helmets[_index].SetActive(false);

            _index++;

            if (_index > 2)
            {
                _index = 0;
            }

            _helmets[_index].SetActive(true);

            SetupCharacterManager.KnightHelmetId =
                _index;
        }
    }
}
