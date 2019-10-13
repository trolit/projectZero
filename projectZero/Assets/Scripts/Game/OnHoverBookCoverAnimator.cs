using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Game
{
    public class OnHoverBookCoverAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {        
        [SerializeField]
        private Animator _bookAnimator;

        public void OnPointerEnter(PointerEventData eventData)
        {
            _bookAnimator.SetBool("isHovered", true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _bookAnimator.SetBool("isHovered", false);
        }
    }
}
