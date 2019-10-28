using System;
using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    [Obsolete("The SoundEffects script is not used and will be removed after scenes check.")]
    public class SoundEffects : MonoBehaviour
    {
        [SerializeField]
        public AudioSource SfxSource;

        [SerializeField]
        public AudioClip JumpEffect;

        private void Start()
        {
            Debug.LogError($"SoundEffects script on {gameObject.name} found! Make sure to remove it.");

            Debug.Break();
        }
    }
}
