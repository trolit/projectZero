using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Inventory
{
    public class BookHandler : MonoBehaviour
    {
        [SerializeField]
        private string _bookKey;

        [SerializeField]
        private Button _button;

        [SerializeField]
        private GameObject _bookObject;

        private bool _isInteractable = false;

        // Update is called once per frame
        private void Update()
        {
            if (_isInteractable == false)
            {
                SetButtonInteractibility();
            }

            CloseBookOnKey();
        }

        public void OpenBook()
        {
            _bookObject.SetActive(true);
        }

        private void CloseBookOnKey()
        {
            if (gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.K))
            {
                _bookObject.SetActive(false);
            }
        }

        private void SetButtonInteractibility()
        {
            var bookStatus = PlayerPrefs.GetInt(_bookKey);

            if (bookStatus != 1) // if the book has not been bought yet
            {
                _button.interactable = false;

                _isInteractable = false;
            }
            else
            {
                _button.interactable = true;

                _isInteractable = true;
            }
        }
    }
}
    



