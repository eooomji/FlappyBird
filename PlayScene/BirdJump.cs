using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * 5; // (0,5) y방향으로 5만큼 점프
        }
    }

    private void OnCollisionEnter2D(Collision2D other) // 파이프-새 or 새-땅 충돌이 일어났을 때
    {
        if (Score.score > Score.bestScore) Score.bestScore = Score.score;
        SceneManager.LoadScene("GameOverScene");
    }
}
