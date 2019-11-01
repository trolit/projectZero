using UnityEngine;

namespace Assets.Scripts.Fix
{
    public class QuestionMarkPositionFixer : MonoBehaviour
    {
        [SerializeField]
        private Transform _parentTransform;

        private void LateUpdate()
        {
            gameObject.transform.parent = _parentTransform;
        }
    }
}
