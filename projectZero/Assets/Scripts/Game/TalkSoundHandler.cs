using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class TalkSoundHandler : MonoBehaviour
    {
        [SerializeField]
        private List<AudioClip> _csharpClips;

        [SerializeField]
        private List<AudioClip> _javaClips;

        [SerializeField]
        private List<AudioClip> _javaScriptClips;

        [SerializeField]
        private List<AudioClip> _htmlClips;

        [SerializeField]
        private List<AudioClip> _phpClips;

        [SerializeField]
        private AudioSource _audioSource;

        private List<AudioClip> _readyClips;

        private int _clipsAmount;

        private static bool _soundTrigger = false;

        public void PlayOneClip()
        {
            if (string.IsNullOrWhiteSpace(NPCHandler.Language))
            {
                Debug.LogError($"Language property on {gameObject.name} was null.");

                Debug.Break();
            }

            switch (NPCHandler.Language)
            {
                case "csharp":
                    var value = Random.Range(0, _csharpClips.Count);
                    _audioSource.PlayOneShot(_csharpClips[value]);
                    break;
                case "html":
                    value = Random.Range(0, _htmlClips.Count);
                    _audioSource.PlayOneShot(_htmlClips[value]);
                    break;
                case "php":
                    value = Random.Range(0, _phpClips.Count);
                    _audioSource.PlayOneShot(_phpClips[value]);
                    break;
                case "java":
                    value = Random.Range(0, _javaClips.Count);
                    _audioSource.PlayOneShot(_javaClips[value]);
                    break;
                case "javascript":
                    value = Random.Range(0, _javaScriptClips.Count);
                    _audioSource.PlayOneShot(_javaScriptClips[value]);
                    break;
            }
        }

        private void Update()
        {
            if (_soundTrigger == true)
            {
                PlayOneClip();

                _soundTrigger = false;
            }
        }

        public static void PlayClipOnConversationStart()
        {
            _soundTrigger = true;
        }
    }
}
