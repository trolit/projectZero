using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class PinCheck : MonoBehaviour
    {
        [SerializeField]
        private string _correctObjectName;

        public static bool IsCorrect = false;

        public static int MistakesAmount = 0;

        [SerializeField]
        private GameObject _verifyButton;

        private void Start()
        {
            _verifyButton.SetActive(false);
        }

        private void OnCollisionEnter(Collision block)
        {
            Debug.Log("Checking => " + block.gameObject.name);

            if (block.gameObject.name == _correctObjectName)
            {
                Debug.Log("Pin placed on correct object!");

                IsCorrect = true;
            }
            else if (block.gameObject.tag == "Wrong")
            {
                Debug.Log("Pin placed on incorrect object!");

                IsCorrect = false;
            }
            else if (block.gameObject.tag == "Player")
            {
                // Show verification button 
                _verifyButton.SetActive(true);
            }
        }
    }
}
