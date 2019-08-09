using UnityEngine;

namespace Assets.Scripts.Minigame_PinPin
{
    public class PinCheck : MonoBehaviour
    {
        [SerializeField]
        private string _correctObjectName;

        public static bool IsCorrect = false;

        void OnCollisionEnter(Collision block)
        {
            if (block.gameObject.name == _correctObjectName)
            {
                Debug.Log("Wybrano prawidlowy blok!");

                IsCorrect = true;
            }
        }
    }
}
