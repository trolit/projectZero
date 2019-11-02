using UnityEngine;

namespace Assets.Scripts.Camera
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _inventoryUi;

        //private bool isActive = false;

        //// Start is called before the first frame update
        //void Start()
        //{

        //}

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                _inventoryUi.SetActive(!_inventoryUi.activeInHierarchy);
                //isActive = true;
            }

            //if (isActive)
            //{
            //    if (Input.GetKeyDown(KeyCode.B))
            //    {
            //        _backpackUi.SetActive(false);
            //        isActive = false;
            //    }

            //}

        }
    }

}
