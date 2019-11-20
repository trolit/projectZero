using Assets.Scripts.Minigame_Skyscraper;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    public class WinScript : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _source;

        [SerializeField]
        private AudioClip _winSound;

        [SerializeField]
        private GameObject _winWindow;

        [SerializeField]
        private bool _testWinSound = false;

        private void Awake()
        {
            _winWindow.SetActive(false);

            enabled = false;
        }

        private void Start()
        {
            _winWindow.SetActive(true);    

            _source.PlayOneShot(_winSound);
        }

        private void Update()
        {
            if (_testWinSound == true)
            {
                if (_source.isPlaying == false)
                {
                    _source.PlayOneShot(_winSound);
                }
            }
        }
    }
}
