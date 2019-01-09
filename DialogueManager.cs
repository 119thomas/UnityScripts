using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    /* we will store/retrieve our sentences from a queue */
    private Queue<string> sentences;

    /* text data variables */
    public Text characterName, characterDialogue;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void HaveDialogue(Dialogue dialogue)
    {
        /* set the name in our dialogue box */
        characterName.text = dialogue.name;

        /* clear the dialogue box and load new dialogue */
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        /* play the next sentence in our dialogue box */
        NextSentence();
    }

    public void NextSentence()
    {
        /* check if we have any sentences to display */
        if (sentences.Count == 0)
        {
            return;
        }

        /* display the next sentence */
        string sentence = sentences.Dequeue();
        characterDialogue.text = sentence;
    }
}