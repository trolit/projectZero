using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.CharacterCreation
{
    public class KnightCharacterManager : MonoBehaviour
    {
        [SerializeField]
        private Button _changeHelmet;

        [SerializeField]
        private Toggle _areShouldersEnabled;

        [SerializeField]
        private GameObject _shoulders;

        [SerializeField]
        private List<GameObject> _helmets;

        private int _index = 0;

        void Start()
        {
            _changeHelmet.gameObject.SetActive(false);
            _areShouldersEnabled.gameObject.SetActive(false);

            var medals = PlayerPrefs.GetInt("medalsUnlocked");

            if (medals < 4)
            {
                _changeHelmet.gameObject.SetActive(false);
                _areShouldersEnabled.gameObject.SetActive(false);
            }

            _helmets[0].SetActive(true);
        }

        public void ManageShoulders()
        {
            _shoulders.SetActive(!_shoulders.activeInHierarchy);

            SetupCharacterManager.KnightShoulders = 
                _shoulders.activeInHierarchy ? 1 : 0;
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
        }
    }
}
