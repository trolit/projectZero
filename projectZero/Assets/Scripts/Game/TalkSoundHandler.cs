using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.WebCam;

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
            }
        }
    }
}
