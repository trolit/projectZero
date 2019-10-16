using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    // SCRIPT ALLOWS TO CREATE RANDOM MOVEMENT FOR
    // OBJECT THAT CONTAINS 2 ANIMATIONS AND SOUND
    // EFFECT TO PLAY WHEN PLAYER GETS CLOSE

    // Warning: Animator needs to contain Walk parameter
    // of type Integer where value 0 means Idle and value
    // 1 means Walk

    // Warning: SphereCollider MUST BE SET as TRIGGER!
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(AudioSource))]
    public class MoveRandomly3 : MoveRandomlyAdvanced
    {
        [SerializeField]
        private List<AudioClip> _soundEffect;

        private AudioSource _soundSource;

        // Use this for initialization
        private new void Start()
        {
            base.Start();

            _soundSource = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                var soundEffectId = Random.Range(0, _soundEffect.Count);
                _soundSource.PlayOneShot(_soundEffect[soundEffectId]);
            }
        }    
    }
}

