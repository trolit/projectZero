using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.CharacterCreation
{
    public class Validate : MonoBehaviour
    {
        public Button PlayButton;

        public InputField Name;

        void FixedUpdate()
        {
            if (string.IsNullOrWhiteSpace(Name.text))
            {
                PlayButton.interactable = false;
            }
            else
            {
                PlayButton.interactable = true;
            }


        }
    }
}
