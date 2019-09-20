using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class OnHoverTextChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField]
        private Text _text;

        public void OnPointerEnter(PointerEventData eventData)
        {
            _text.fontSize = 20;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _text.fontSize = 16;
        }
    }
}
