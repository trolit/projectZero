﻿using UnityEngine;

namespace Assets.Scripts.Game
{
    public class StopMenuMusic : MonoBehaviour
    {
        void Start()
        {
            GameObject.FindGameObjectWithTag("Music")
                .GetComponent<MusicThroughScenes>()
                .StopMusic();
        }
    }
}
