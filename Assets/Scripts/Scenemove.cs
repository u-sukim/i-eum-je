using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapTransition : MonoBehaviour
{
    public string Village; // ��ȯ�� �� �̸�

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾ Ʈ���ſ� �����ϸ� �� ��ȯ
            SceneManager.LoadScene("Village");
        }
    }
}
