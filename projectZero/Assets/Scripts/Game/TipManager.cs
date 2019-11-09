using UnityEngine;

namespace Assets.Scripts.Game
{
    public class TipManager : MonoBehaviour
    {
        public static TipManager instance = null;

        [SerializeField]
        [Tooltip("Setting this on true will cause the tips to appear every time the action is performed.")]
        private bool _isUnderTest = false;

        [SerializeField]
        private GameObject _tipBody;

        [SerializeField]
        private GameObject _newGameTip;

        [SerializeField]
        private GameObject _interactWithNPCTip;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);

                Debug.LogWarning($"Since there is already one instance of TipManager," +
                                 $" instance on {gameObject.name} was destroyed.");
            }
        }
    }
}
