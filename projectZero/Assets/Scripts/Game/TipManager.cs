using UnityEngine;

namespace Assets.Scripts.Game
{
    public class TipManager : MonoBehaviour
    {
        public static TipManager instance = null;

        [SerializeField]
        [Tooltip("Setting this on true will cause the tips to appear every time the action is performed.")]
        private bool _isUnderTest = false;

        [SerializeField]
        private GameObject _tipBody;

        [SerializeField]
        private GameObject _newGameTip;

        [SerializeField]
        private GameObject _interactWithNPCTip;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);

                Debug.LogWarning($"Since there is already one instance of TipManager," +
                                 $" instance on {gameObject.name} was destroyed.");
            }
        }

        private void SetTimeScale(float value)
        {
            Time.timeScale = value;
        }

        public void InvokeInteractionWithNpcTip()
        {
            SetTimeScale(0f);

            _tipBody.SetActive(true);

            _interactWithNPCTip.SetActive(true);
        }

        public void InvokeNewGameTip()
        {
            SetTimeScale(0f);

            _tipBody.SetActive(true);

            _newGameTip.SetActive(true);
        }

        public void CloseAndSave(string key)
        {
            SetTimeScale(1f);

            if (_isUnderTest == false)
            {
                PlayerPrefs.SetInt(key, 1);
            }
            else if (_isUnderTest == true)
            {
                Debug.Log($"Information about tip NOT SAVED as\n TESTING variable ON {gameObject.name} is TRUE.");
            }

            _tipBody.SetActive(false);

            _interactWithNPCTip.SetActive(false);

            _newGameTip.SetActive(false);
        }
    }
}
