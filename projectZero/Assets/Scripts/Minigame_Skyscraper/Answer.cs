using UnityEngine;

namespace Assets.Scripts.Minigame_Skyscraper
{
    [RequireComponent(typeof(BoxCollider))]
    public class Answer : MonoBehaviour
    {
        [SerializeField]
        protected AudioSource Source;

        [SerializeField]
        protected AudioClip Clip;

        protected bool IsOnQuestion = false;

        private void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                IsOnQuestion = true;
            }
        }

        private void OnCollisionStay(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                IsOnQuestion = true;
            }
        }

        private void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                IsOnQuestion = false;
            }
        }
    }
}
