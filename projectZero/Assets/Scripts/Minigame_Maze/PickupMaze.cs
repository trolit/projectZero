using UnityEngine;

namespace Assets.Scripts.Minigame_Maze
{
    public class PickupMaze : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _source;

        [SerializeField]
        private AudioClip _bugPickedClip;

        [SerializeField]
        private AudioClip _codePickedClip;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Pickable")
            {
                MazeMinigame.CurrentlyPicked++;

                _source.PlayOneShot(_codePickedClip);

                other.gameObject.SetActive(false);
            }
            else if (other.gameObject.tag == "Bug")
            {
                MazeMinigame.BugsPicked++;

                _source.PlayOneShot(_bugPickedClip);

                other.gameObject.SetActive(false);
            }
        }
    }
}
