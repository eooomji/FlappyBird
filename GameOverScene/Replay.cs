using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame() // PlayScene으로 넘어가는 함수 생성
    {
        SceneManager.LoadScene("PlayScene");
    }
}
