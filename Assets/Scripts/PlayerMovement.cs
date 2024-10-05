using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update()
    {
        // �Է� ���� (WASD Ű �Ǵ� ȭ��ǥ Ű)
        movement.x = Input.GetAxisRaw("Horizontal"); // �¿� �̵�
        movement.y = Input.GetAxisRaw("Vertical");   // ���� �̵�

        // �밢�� �Է� ����: �ϳ��� ���⸸ �����̵��� ����
        if (movement.x != 0)
        {
            movement.y = 0; // �¿� �̵� �� ���� �������� ����
        }
        else if (movement.y != 0)
        {
            movement.x = 0; // ���� �̵� �� �¿� �������� ����
        }
    }

    void FixedUpdate()
    {
        // Rigidbody2D�� ����� ���� �̵� ó��
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
