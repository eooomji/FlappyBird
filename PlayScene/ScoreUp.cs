using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Score.score++; // Score.cs에서 선언한 score 변수의 값 증가
    }
}
