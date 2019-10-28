using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class StrapColorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField]
        private string _colorName;

        [Header("RGB value")]

        [SerializeField]
        private byte _r;

        [SerializeField]
        private byte _g;

        [SerializeField]
        private byte _b;

        public void OnPointerEnter(PointerEventData eventData)
        {
            GameObject.FindGameObjectWithTag("Strap")
                .GetComponent<Image>().color = new Color32(_r, _g, _b, 0xFF);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            GameObject.FindGameObjectWithTag("Strap")
                .GetComponent<Image>().color = new Color32(0xF9, 0x67, 0x14, 0xFF); // Orange Tiger
        }
    }
}
