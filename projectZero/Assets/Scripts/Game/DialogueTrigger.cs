using UnityEngine;

namespace Assets.Scripts.Game
{
    public class DialogueTrigger : MonoBehaviour
    {
        public Dialogue Dialogue;

        public void TriggerDialogue()
        {
            FindObjectOfType<DialogueManager>().StartDialogue(Dialogue);
        }


    }
}
