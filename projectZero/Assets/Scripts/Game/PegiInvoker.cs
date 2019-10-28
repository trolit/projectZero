using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class PegiInvoker : MonoBehaviour
    {
        [SerializeField]
        private RawImage _source;

        [SerializeField]
        private string _followingSceneName;

        private IEnumerator Start()
        {
            _source.canvasRenderer.SetAlpha(0.0f);

            FadeIn();

            yield return new WaitForSeconds(2.5f);

            FadeOut();

            yield return new WaitForSeconds(2.5f);

            SceneManager.LoadSceneAsync(_followingSceneName);
        }

        private void FadeIn()
        {
            _source.CrossFadeAlpha(1.0f, 1.5f, false);
        }

        private void FadeOut()
        {
            _source.CrossFadeAlpha(0.0f, 2.5f, false);
        }
    }
}
