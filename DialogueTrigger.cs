using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue[] dialogues;
    public int character;

    /* this method is used to locate our DialogueManager and begin dialogue;
     * where the information given is from our current dialogue object */
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().HaveDialogue(dialogues[character]);
    }
}
