using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Inventory
{
    public class NotifierHandler : MonoBehaviour
    {
        public static NotifierHandler instance = null;

        [NonSerialized]
        public int LevelValue;

        [NonSerialized]
        public Texture LogoTexture;

        [SerializeField]
        private Text _levelText;

        [SerializeField]
        private RawImage _logoPlaceHolder;

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

        public void SetupNotifier()
        {
            _levelText.text = LevelValue.ToString();

            _logoPlaceHolder.texture = LogoTexture;
        }
    }
}
