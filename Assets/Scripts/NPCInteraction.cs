using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public GameObject dialoguePanel; // 대화창 패널

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D was called"); // 충돌 함수 진입 확인

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered NPC's trigger zone");
            dialoguePanel.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D was called"); // 충돌 함수 진입 확인

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has exited NPC's trigger zone");
            dialoguePanel.SetActive(false);
        }
    }


}

