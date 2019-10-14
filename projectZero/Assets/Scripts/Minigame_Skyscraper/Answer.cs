using UnityEngine;

namespace Assets.Scripts.Minigame_Skyscraper
{
    public class Answer : MonoBehaviour
    {
        [SerializeField]
        protected AudioSource Source;

        [SerializeField]
        protected AudioClip Clip;

        protected bool IsOnQuestion = false;

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                IsOnQuestion = true;
            }
        }

        void OnCollisionStay(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                IsOnQuestion = true;
            }
        }

        void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                IsOnQuestion = false;
            }
        }
    }
}
