using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class UpdateMinigameLoaderData : MonoBehaviour
    {
        [SerializeField]
        private Text _languageText;

        [SerializeField]
        private Image _sliderFillImage;

        [SerializeField]
        private Text _descriptionText;

        [SerializeField]
        private List<Texture> _imagesList;

        private Color _lime = new Color(0f, 255f, 0f);

        private Color _orange = new Color(255f, 165f, 0f);

        // Start is called before the first frame update
        void Awake()
        {
            var baseText = "Wczytywanie poziomu krainy";

            _languageText.text = baseText;

            if (LevelLoader.CrossSceneInformation == null)
            {
                _languageText.text = "No language set.";

                _sliderFillImage.color = Color.red;
            }
            else if (LevelLoader.CrossSceneInformation.Contains("JS"))
            {
                _languageText.text += "<color=cyan> JavaScript</color>";

                _sliderFillImage.color = Color.cyan;
            }
            else if (LevelLoader.CrossSceneInformation.Contains("C#"))
            {
                _languageText.text += "<color=lime> C#</color>";

                _sliderFillImage.color = _lime;
            }
            else if (LevelLoader.CrossSceneInformation.Contains("Java"))
            {
                _languageText.text += "<color=yellow> Java</color>";

                _sliderFillImage.color = Color.yellow;
            }
            else if (LevelLoader.CrossSceneInformation.Contains("HTML"))
            {
                _languageText.text += "<color=magenta> HTML</color>";

                _sliderFillImage.color = Color.magenta;
            }
            else if (LevelLoader.CrossSceneInformation.Contains("PHP"))
            {
                _languageText.text += "<color=orange> PHP</color>";

                _sliderFillImage.color = _orange;
            }

            if (TextStorage.Texts != null)
            {
                var max = TextStorage.Texts.Count;

                var value = Random.Range(0, max);

                _descriptionText.text = TextStorage.Texts[value];
            }
            else
            {
                _descriptionText.text = "No description provided.";
            }
        }
    }
}
