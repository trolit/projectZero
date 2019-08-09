using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class VerifySection : MonoBehaviour
    {
        [SerializeField]
        private GameObject _section;

        [SerializeField]
        private GameObject _sectionGround;

        [SerializeField]
        private GameObject _pinModel;

        void OnCollisionEnter(Collision player)
        {
            if (player.gameObject.tag == "Player")
            {           
                // Check
                if (PinCheck.IsCorrect)
                {
                    Destroy(_section);
                    Destroy(_sectionGround);
                    Destroy(_pinModel);
                }
            }
        }

    }
}
