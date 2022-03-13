using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 가져올 때

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString(); // C#에도 ToString이..!!!! int -> string으로 바꿔줄 때 사용
    }
}
