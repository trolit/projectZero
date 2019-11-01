using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class DialogueManager : MonoBehaviour
    {
        public Text NPCNameText;

        public Text DialogueText;

        public Animator Animator;

        private string _playerName;

        [SerializeField]
        private GameObject _functionalButtons;

        // FIFO (First in First out)
        private Queue<string> sentences;

        private void Start()
        {
            sentences = new Queue<string>();

            _playerName = PlayerPrefs.GetString("name");
        }

        private void Update()
        {
            if (NPCHandler.IsPlayerInDialogueArea == false)
            {
                EndDialogue();
            }
        }

        public void StartDialogue(Dialogue dialogue)
        {
            Animator.SetBool("isOpen", true);

            sentences.Clear();

            NPCNameText.text = dialogue.Name;

            foreach (var sentece in dialogue.Sentences)
            {
                sentences.Enqueue(sentece);
            }

            DisplayNextSentence();
        }

        public void DisplayNextSentence()
        {
            if (sentences.Count == 1)
            {
                // Display buttons accept(play mini-game) or decline

                _functionalButtons.SetActive(true);
            }

            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();

            if (sentence.Contains("{PLAYERNAME}"))
            {
                sentence = sentence.Replace("{PLAYERNAME}", _playerName);
            }

            StopAllCoroutines();
            
            StartCoroutine(TypeSentence(sentence));
        }

        private IEnumerator TypeSentence(string sentence)
        {
            DialogueText.text = "";

            foreach (var letter in sentence.ToCharArray())
            {
                DialogueText.text += letter;

                yield return null;
            }
        }

        public void EndDialogue()
        {
            Animator.SetBool("isOpen", false);

            _functionalButtons.SetActive(false);

            NPCHandler.IsDuringConveration = false;
        }     
    }
}
