using UnityEngine;

namespace Assets.Scripts.Game
{
    public class PlayMenuMusic : MonoBehaviour
    {
        void Start()
        {
            GameObject.FindGameObjectWithTag("Music")
                .GetComponent<MusicThroughScenes>()
                .PlayMusic();
        }
    }
}
