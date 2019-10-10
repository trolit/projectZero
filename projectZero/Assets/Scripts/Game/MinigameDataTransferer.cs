using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    // Put this on NPC that has quest for player
    // to pass data which level needs to be loaded

    public class MinigameDataTransferer : MonoBehaviour
    {
        [SerializeField]
        private string _sceneName;

        void Start()
        {
            if (string.IsNullOrWhiteSpace(_sceneName) == false)
            {
                LevelLoader.CrossSceneInformation = _sceneName;

                SceneManager.LoadSceneAsync("MinigameLoader");
            }
            else
            {
                Debug.LogError($"Problem occured with _sceneName on {gameObject.name}");

                Debug.Break();
            }
        }
    }
}
