using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower; // public으로 변수 선언하면 Unity Inspector 창에서도 보임, 변수 값 변경 가능

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 눌렀을 때
        {
            rb.velocity = Vector2.up * 5; // (0,5) y방향으로 5만큼 점프
        }
    }
}
