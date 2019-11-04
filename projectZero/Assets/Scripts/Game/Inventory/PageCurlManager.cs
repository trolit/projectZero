using UnityEngine;

namespace Assets.Scripts.Game.Inventory
{
    public class PageCurlManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _pageCurlBooks;

        // Update is called once per frame
        private void Update()
        {
            if (_pageCurlBooks.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    _pageCurlBooks.SetActive(false);
                }
            }
            
        }
    }

}