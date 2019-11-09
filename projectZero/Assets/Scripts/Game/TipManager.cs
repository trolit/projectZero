using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class TipManager : MonoBehaviour
    {
        public static TipManager instance = null;

        [SerializeField]
        [Tooltip("Setting this on true will cause the tips to be NOT SAVED WHEN CLOSED.")]
        private bool _isUnderTest = false;

        [SerializeField]
        private List<GameObject> _tipList;

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

        private void ActivateTipBody()
        {
            _tipList[0].SetActive(true);
        }
        
        public void InvokeInteractionWithNpcTip()
        {
            SetTimeScale(0f);

            ActivateTipBody();

            _tipList[2].SetActive(true);
        }

        public void InvokeNewGameTip()
        {
            SetTimeScale(0f);

            ActivateTipBody();

            _tipList[1].SetActive(true);
        }

        public void InvokeShopTip()
        {
            SetTimeScale(0f);

            ActivateTipBody();

            _tipList[3].SetActive(true);
        }

        public void InvokeNoActiveTasksTip()
        {
            SetTimeScale(0f);

            ActivateTipBody();

            _tipList[4].SetActive(true);
        }

        public void InvokeOneLandFinishedTip()
        {
            SetTimeScale(0f);

            ActivateTipBody();

            _tipList[5].SetActive(true);
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

            foreach (var tipBody in _tipList)
            {
                tipBody.SetActive(false);
            }
        }
    }
}
