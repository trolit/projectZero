using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Minigame_Maze
{
    public class RestartScene : MonoBehaviour
    {
        public void RestartCurrentScene()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync(scene.name);
        }
    }
}
