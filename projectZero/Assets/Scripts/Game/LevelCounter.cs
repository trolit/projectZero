using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class LevelCounter : MonoBehaviour
    {
        public static LevelCounter instance = null;

        [NonSerialized]
        public int CsharpActive = 0;
        [NonSerialized]
        public int CsharpInActive = 0;
        [NonSerialized]
        public int CsharpFinished = 0;

        [NonSerialized]
        public int JavaActive = 0;
        [NonSerialized]
        public int JavaInActive = 0;
        [NonSerialized]
        public int JavaFinished = 0;

        [NonSerialized]
        public int JsActive = 0;
        [NonSerialized]
        public int JsInActive = 0;
        [NonSerialized]
        public int JsFinished = 0;

        [NonSerialized]
        public int HtmlActive = 0;
        [NonSerialized]
        public int HtmlInActive = 0;
        [NonSerialized]
        public int HtmlFinished = 0;

        [NonSerialized]
        public int PhpActive = 0;
        [NonSerialized]
        public int PhpInActive = 0;
        [NonSerialized]
        public int PhpFinished = 0;

        [Header("Active text references")]

        [SerializeField]
        private Text _csharpActiveText;

        [SerializeField]
        private Text _phpActiveText;

        [SerializeField]
        private Text _jsActiveText;

        [SerializeField]
        private Text _javaActiveText;

        [SerializeField]
        private Text _htmlActiveText;

        [Header("InActive text references")]

        [SerializeField]
        private Text _csharpInActiveText;

        [SerializeField]
        private Text _phpInActiveText;

        [SerializeField]
        private Text _jsInActiveText;

        [SerializeField]
        private Text _javaInActiveText;

        [SerializeField]
        private Text _htmlInActiveText;

        [Header("Finished text references")]

        [SerializeField]
        private Text _csharpFinishedText;

        [SerializeField]
        private Text _phpFinishedText;

        [SerializeField]
        private Text _jsFinishedText;

        [SerializeField]
        private Text _javaFinishedText;

        [SerializeField]
        private Text _htmlFinishedText;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);

                Debug.LogWarning($"Since there is already one instance of LevelCounter," +
                                 $" instance on {gameObject.name} was destroyed.");
            }
        }

        public void UpdateTextValues()
        {
            _csharpActiveText.text = CsharpActive.ToString();
            _csharpInActiveText.text = CsharpInActive.ToString();
            _csharpFinishedText.text = CsharpFinished.ToString();

            _htmlActiveText.text = HtmlActive.ToString();
            _htmlInActiveText.text = HtmlInActive.ToString();
            _htmlFinishedText.text = HtmlFinished.ToString();

            _phpActiveText.text = PhpActive.ToString();
            _phpInActiveText.text = PhpInActive.ToString();
            _phpFinishedText.text = PhpFinished.ToString();

            _javaActiveText.text = JavaActive.ToString();
            _javaInActiveText.text = JavaInActive.ToString();
            _javaFinishedText.text = JavaFinished.ToString();

            _jsActiveText.text = JsActive.ToString();
            _jsInActiveText.text = JsInActive.ToString();
            _jsFinishedText.text = JsFinished.ToString();
        }
    }
}
