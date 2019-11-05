using System;
using UnityEngine;

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
        public int JavaActive = 0;
        [NonSerialized]
        public int JavaInActive = 0;

        [NonSerialized]
        public int JsActive = 0;
        [NonSerialized]
        public int JsInActive = 0;

        [NonSerialized]
        public int HtmlActive = 0;
        [NonSerialized]
        public int HtmlInActive = 0;

        [NonSerialized]
        public int PhpActive = 0;
        [NonSerialized]
        public int PhpInActive = 0;

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
    }
}
