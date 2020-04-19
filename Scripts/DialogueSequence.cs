using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSequence : MonoBehaviour
{
    public GameObject[] dialogues;
    public int numberOfDialogues;
    public float timeForDialogues;

    private float timeBetweenDialogue;

    // Start is called before the first frame update
    void Start()
    {
        timeBetweenDialogue = timeForDialogues / numberOfDialogues;
        StartCoroutine(DialogueFlow());
    }

    IEnumerator DialogueFlow()
    {
        for(int i = 0; i < numberOfDialogues; i++)
        {
            dialogues[i].SetActive(true);
            yield return new WaitForSeconds(timeBetweenDialogue);
            dialogues[i].SetActive(false);
        }
        yield break;
    }
}
