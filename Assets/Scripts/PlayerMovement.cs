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
        // 입력 감지 (WASD 키 또는 화살표 키)
        movement.x = Input.GetAxisRaw("Horizontal"); // 좌우 이동
        movement.y = Input.GetAxisRaw("Vertical");   // 상하 이동

        // 대각선 입력 방지: 하나의 방향만 움직이도록 설정
        if (movement.x != 0)
        {
            movement.y = 0; // 좌우 이동 시 상하 움직임을 막음
        }
        else if (movement.y != 0)
        {
            movement.x = 0; // 상하 이동 시 좌우 움직임을 막음
        }
    }

    void FixedUpdate()
    {
        // Rigidbody2D를 사용한 실제 이동 처리
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
