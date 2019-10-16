﻿using UnityEngine;

namespace Assets.Scripts.Game.Player
{
    public class SpawnPlayer : MonoBehaviour
    {
        public GameObject Cactus;

        public GameObject Robot;

        public GameObject Slime;

        public GameObject Knight;

        [SerializeField]
        private AudioSource _sfxSource;

        [SerializeField]
        private AudioClip _slimeJump;

        [SerializeField]
        private AudioClip _cactusJump;

        [SerializeField]
        private AudioClip _robotJump;

        [SerializeField]
        private AudioClip _knightMove;

        void Start()
        {
            var pickedModel = PlayerPrefs.GetInt("model");

            if (pickedModel == 1) // Cactus
            {
                Cactus.SetActive(true);

                MovementScript movement = Cactus.AddComponent<MovementScript>();
                movement.Speed = 40f;

                movement.SfxSource = _sfxSource;
                movement.SfxSource.clip = _cactusJump;

            }
            else if (pickedModel == 2) // Slime
            {
                Slime.SetActive(true);

                MovementScript movement = Slime.AddComponent<MovementScript>();
                movement.Speed = 70f;

                movement.SfxSource = _sfxSource;
                movement.SfxSource.clip = _slimeJump;
            }
            else if (pickedModel == 3) // Robot
            {
                Robot.SetActive(true);

                MovementScript movement = Robot.AddComponent<MovementScript>();
                movement.Speed = 40f;

                movement.SfxSource = _sfxSource;
                movement.SfxSource.clip = _robotJump;
            }
            else if (pickedModel == 4) // Knight
            {
                Knight.SetActive(true);

                MovementScript movement = Knight.AddComponent<MovementScript>();
                movement.Speed = 30f;

                movement.SfxSource = _sfxSource;
                movement.SfxSource.clip = _knightMove;
            }
            else
            {
                Debug.Log(
                    $"Character wasn't picked! (model value was: {PlayerPrefs.GetInt("model")})");
            }
        }
    }
}
