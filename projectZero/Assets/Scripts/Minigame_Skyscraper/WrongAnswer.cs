using UnityEngine;

namespace Assets.Scripts.Minigame_Skyscraper
{
    public class WrongAnswer : Answer
    {
        [SerializeField]
        private GameObject _wrongAnswerObject;

        private void Start()
        {
            _wrongAnswerObject.SetActive(false);
        }

        private void Update()
        {
            if (IsOnQuestion == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _wrongAnswerObject.SetActive(true);

                    Source.PlayOneShot(Clip);

                    SkyscraperPrizeManager.MistakesCount++;
                }
            }
        }

        
    }
}
