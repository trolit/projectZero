using UnityEngine;

namespace Assets.Scripts.CharacterCreation
{
    public class ExtraCharacterToggler : MonoBehaviour
    {
        [SerializeField]
        private GameObject _knightButton;

        private void Start()
        {
            var medalsAmount = PlayerPrefs.GetInt("medalsUnlocked");

            if (medalsAmount >= 2)
            {
                _knightButton.SetActive(true);

                gameObject.transform.localPosition = new Vector3(2f, gameObject.transform.localPosition.y, 0f);
            }
            else
            {
                _knightButton.SetActive(false);

                gameObject.transform.localPosition = new Vector3(64.7f, gameObject.transform.localPosition.y, 0f);
            }
        }
    }
}
