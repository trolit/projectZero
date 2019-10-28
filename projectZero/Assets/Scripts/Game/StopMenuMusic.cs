using UnityEngine;

namespace Assets.Scripts.Game
{
    public class StopMenuMusic : MonoBehaviour
    {
        private void Start()
        {
            GameObject.FindGameObjectWithTag("Music")
                .GetComponent<MusicThroughScenes>()
                .StopMusic();
        }
    }
}
