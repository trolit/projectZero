using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Assets.Scripts.Game.TextStorage;

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

        [SerializeField]
        private RawImage _sceneImage;

        private Color _lime = new Color(0f, 255f, 0f);

        // The orange color needs to be in 32 bit format
        private Color32 _orange = new Color32(227, 150, 16, 255);

        private int _textsCount;

        // Start is called before the first frame update
        private void Start()
        {
            var baseText = "Wczytywanie poziomu krainy";

            if (Texts == null)
            {
                Debug.LogError($"Texts on {gameObject.name} cannot be null.");

                Debug.Break();
            }

            _textsCount = Texts.Count;

            if (_textsCount != 0)
            {
                RandomizeText();
            }
            
            StartCoroutine(CallForTextChange());

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

                switch (LevelLoader.CrossSceneInformation)
                {
                    case "PinPin_JS_1":
                        _sceneImage.texture = _imagesList[16];
                        break;
                    case "PinPin_JS_2":
                        _sceneImage.texture = _imagesList[17];
                        break;
                    case "Puzzle_JS_1":
                        _sceneImage.texture = _imagesList[26];
                        break;
                    case "Puzzle_JS_2":
                        _sceneImage.texture = _imagesList[27];
                        break;
                    case "Maze_JS_1":
                        _sceneImage.texture = _imagesList[6];
                        break;
                    case "Maze_JS_2":
                        _sceneImage.texture = _imagesList[7];
                        break;
                    case "Skyscraper_JS_1":
                        _sceneImage.texture = _imagesList[36];
                        break;
                    case "Skyscraper_JS_2":
                        _sceneImage.texture = _imagesList[37];
                        break;
                    default:
                        Debug.LogError("No image according to source! (scene name is case sensitive)");
                        Debug.Break();
                        break;
                }
            }
            else if (LevelLoader.CrossSceneInformation.Contains("C#"))
            {
                _languageText.text += "<color=lime> C#</color>";

                _sliderFillImage.color = _lime;

                switch (LevelLoader.CrossSceneInformation)
                {
                    case "PinPin_C#_1":
                        _sceneImage.texture = _imagesList[10];
                        break;
                    case "PinPin_C#_2":
                        _sceneImage.texture = _imagesList[11];
                        break;
                    case "Puzzle_C#_1":
                        _sceneImage.texture = _imagesList[20];
                        break;
                    case "Puzzle_C#_2":
                        _sceneImage.texture = _imagesList[21];
                        break;
                    case "Maze_C#_1":
                        _sceneImage.texture = _imagesList[0];
                        break;
                    case "Maze_C#_2":
                        _sceneImage.texture = _imagesList[1];
                        break;
                    case "Skyscraper_C#_1":
                        _sceneImage.texture = _imagesList[30];
                        break;
                    case "Skyscraper_C#_2":
                        _sceneImage.texture = _imagesList[31];
                        break;
                    default:
                        Debug.LogError("No image according to source! (scene name is case sensitive)");
                        Debug.Break();
                        break;
                }
            }
            else if (LevelLoader.CrossSceneInformation.Contains("Java"))
            {
                _languageText.text += "<color=yellow> Java</color>";

                _sliderFillImage.color = Color.yellow;

                switch (LevelLoader.CrossSceneInformation)
                {
                    case "PinPin_Java_1":
                        _sceneImage.texture = _imagesList[14];
                        break;
                    case "PinPin_Java_2":
                        _sceneImage.texture = _imagesList[15];
                        break;
                    case "Puzzle_Java_1":
                        _sceneImage.texture = _imagesList[24];
                        break;
                    case "Puzzle_Java_2":
                        _sceneImage.texture = _imagesList[25];
                        break;
                    case "Maze_Java_1":
                        _sceneImage.texture = _imagesList[4];
                        break;
                    case "Maze_Java_2":
                        _sceneImage.texture = _imagesList[5];
                        break;
                    case "Skyscraper_Java_1":
                        _sceneImage.texture = _imagesList[34];
                        break;
                    case "Skyscraper_Java_2":
                        _sceneImage.texture = _imagesList[35];
                        break;
                    default:
                        Debug.LogError("No image according to source! (scene name is case sensitive)");
                        Debug.Break();
                        break;
                }
            }
            else if (LevelLoader.CrossSceneInformation.Contains("HTML"))
            {
                _languageText.text += "<color=magenta> HTML</color>";

                _sliderFillImage.color = Color.magenta;

                switch (LevelLoader.CrossSceneInformation)
                {
                    case "PinPin_HTML_1":
                        _sceneImage.texture = _imagesList[12];
                        break;
                    case "PinPin_HTML_2":
                        _sceneImage.texture = _imagesList[13];
                        break;
                    case "Puzzle_HTML_1":
                        _sceneImage.texture = _imagesList[22];
                        break;
                    case "Puzzle_HTML_2":
                        _sceneImage.texture = _imagesList[23];
                        break;
                    case "Maze_HTML_1":
                        _sceneImage.texture = _imagesList[2];
                        break;
                    case "Maze_HTML_2":
                        _sceneImage.texture = _imagesList[3];
                        break;
                    case "Skyscraper_HTML_1":
                        _sceneImage.texture = _imagesList[32];
                        break;
                    case "Skyscraper_HTML_2":
                        _sceneImage.texture = _imagesList[33];
                        break;
                    default:
                        Debug.LogError("No image according to source! (scene name is case sensitive)");
                        Debug.Break();
                        break;
                }
            }
            else if (LevelLoader.CrossSceneInformation.Contains("PHP"))
            {
                _languageText.text += "<color=orange> PHP</color>";

                _sliderFillImage.color = _orange;

                switch (LevelLoader.CrossSceneInformation)
                {
                    case "PinPin_PHP_1":
                        _sceneImage.texture = _imagesList[18];
                        break;
                    case "PinPin_PHP_2":
                        _sceneImage.texture = _imagesList[19];
                        break;
                    case "Puzzle_PHP_1":
                        _sceneImage.texture = _imagesList[28];
                        break;
                    case "Puzzle_PHP_2":
                        _sceneImage.texture = _imagesList[29];
                        break;
                    case "Maze_PHP_1":
                        _sceneImage.texture = _imagesList[8];
                        break;
                    case "Maze_PHP_2":
                        _sceneImage.texture = _imagesList[9];
                        break;
                    case "Skyscraper_PHP_1":
                        _sceneImage.texture = _imagesList[38];
                        break;
                    case "Skyscraper_PHP_2":
                        _sceneImage.texture = _imagesList[39];
                        break;
                    default:
                        Debug.LogError("No image according to source! (scene name is case sensitive)");
                        Debug.Break();
                        break;
                }
            }

            Debug.Log("Texts => " + Texts.Count);
        }

        private IEnumerator CallForTextChange()
        {
            while (true)
            {
                yield return new WaitForSeconds(9f);

                RandomizeText();
            }
        }

        private void RandomizeText()
        {
            var value = Random.Range(0, _textsCount);

            _descriptionText.text = Texts[value];
        }
    }
}
