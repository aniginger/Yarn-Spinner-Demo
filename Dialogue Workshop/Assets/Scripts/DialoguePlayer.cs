using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialoguePlayer : MonoBehaviour
{
    // internal properties exposed to editor
    public string conversationStartNode;
    private DialogueRunner dialogueRunner;

    void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            dialogueRunner.StartDialogue(conversationStartNode);
        }
    }
}

