using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    public class ProcessingHandler : MonoBehaviour
    {
        private IEnumerator Start()
        {
            yield return new WaitForSeconds(3.5f);

            LoadNextSceneAsync();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                LoadNextSceneAsync();
            }
        }

        private void LoadNextSceneAsync()
        {
            SceneManager.LoadSceneAsync("MenuLoader");
        }
    }
}
