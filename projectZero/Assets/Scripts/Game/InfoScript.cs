using UnityEngine;

namespace Assets.Scripts.Game
{
    public class InfoScript : MonoBehaviour
    {
        [SerializeField]
        private GameObject _infoWindow;

        private void Start()
        {
            _infoWindow.SetActive(true);
        }
    }
}
