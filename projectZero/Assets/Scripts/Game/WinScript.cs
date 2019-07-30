using UnityEngine;

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

        void Awake()
        {
            enabled = false;
        }

        void Start()
        {
            _winWindow.SetActive(true);

            _source.PlayOneShot(_winSound);
        }
    }
}
