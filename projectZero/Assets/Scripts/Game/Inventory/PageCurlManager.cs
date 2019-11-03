using UnityEngine;

namespace Assets.Scripts.Game.Inventory
{
    public class PageCurlManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _pageCurlUi;

        // Update is called once per frame
        void Update()
        {
            if (_pageCurlUi.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    _pageCurlUi.SetActive(false);
                }
            }
            
        }
    }

}