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

        // Used in BookHandler script
        // When someone buys book while on map
        // - it updates details panel values 
        public void HandleValueManually(string key)
        {
            switch (key)
            {
                case "C#":
                    if (CsharpInActive > 0)
                        CsharpInActive--;

                    CsharpActive++;
                    break;
                case "HTML":
                    if (HtmlInActive > 0)
                        HtmlInActive--;

                    HtmlActive++;
                    break;
                case "PHP":
                    if (PhpInActive > 0)
                        PhpInActive--;

                    PhpActive++;
                    break;
                case "JAVASCRIPT":
                    if (JsInActive > 0)
                        JsInActive--;

                    JsActive++;
                    break;
                case "JAVA":
                    if (JavaInActive > 0)
                        JavaInActive--;

                    JavaActive++;
                    break;
            }
        }

        public void UpdateTextValues()
        {
            _csharpActiveText.text = "<color=lime>" + CsharpActive + "</color>";
            _csharpInActiveText.text = "<color=lime>" + CsharpInActive + "</color>";
            _csharpFinishedText.text = "<color=lime>" + CsharpFinished + "</color>";

            _htmlActiveText.text = "<color=magenta>" + HtmlActive + "</color>";
            _htmlInActiveText.text = "<color=magenta>" + HtmlInActive + "</color>";
            _htmlFinishedText.text = "<color=magenta>" + HtmlFinished + "</color>";

            _phpActiveText.text = "<color=orange>" + PhpActive + "</color>";
            _phpInActiveText.text = "<color=orange>" + PhpInActive + "</color>";
            _phpFinishedText.text = "<color=orange>" + PhpFinished + "</color>";

            _javaActiveText.text = "<color=yellow>" + JavaActive + "</color>";
            _javaInActiveText.text = "<color=yellow>" + JavaInActive + "</color>";
            _javaFinishedText.text = "<color=yellow>" + JavaFinished + "</color>";

            _jsActiveText.text = "<color=cyan>" + JsActive + "</color>";
            _jsInActiveText.text = "<color=cyan>" + JsInActive + "</color>";
            _jsFinishedText.text = "<color=cyan>" + JsFinished + "</color>";

            // If no active tasks - activate tip
            if (CsharpActive == 0 && HtmlActive == 0 && PhpActive == 0
                && JavaActive == 0 && JsActive == 0)
            {
                var noActiveTasksTipState = PlayerPrefs.GetInt("noActiveTasksTip");

                if (noActiveTasksTipState == 0)
                {
                    TipManager.instance.InvokeNoActiveTasksTip();
                }
            }

            // If one land fully finished - activate tip
            if (CsharpFinished == 8 || HtmlFinished == 8 || PhpFinished == 8
                || JavaFinished == 8 || JsFinished == 8)
            {
                var oneLandFinishedState = PlayerPrefs.GetInt("finishOneLandTip");

                if (oneLandFinishedState == 0)
                {
                    TipManager.instance.InvokeOneLandFinishedTip();
                }
            }
        }
    }
}
