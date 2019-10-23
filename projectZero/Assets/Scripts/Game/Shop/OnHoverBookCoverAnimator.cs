using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Game.Shop
{
    public class OnHoverBookCoverAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {        
        [SerializeField]
        private Animator _bookAnimator;

        [SerializeField]
        private string _bookKey;

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (ItemManager.IsAnimationEnabled)
            {
                _bookAnimator.SetBool("isHovered", true);
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _bookAnimator.SetBool("isHovered", false);
        }
    }
}
