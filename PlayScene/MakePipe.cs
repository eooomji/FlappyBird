using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe; // Object file이지만, Inspector 창에서 보임
                            // 미리 만들어놓은 Pipe(Frefab)을, Inspector 창 Pipe 안에 Drag & Drop
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // Time.deltaTime이 계속 더해져 timer가 1이 될 때 => 1초 흘러갔다는 말
        if(timer > timeDiff) // timeDiff == n : n초
        {
            GameObject newpipe = Instantiate(pipe);  // 매 frame마다 pipe를 생성
            newpipe.transform.position = new Vector3(6, Random.Range(0.0f, 3.1f), 0); // (x, y, z) 위치에 놔두겠다
            timer = 0;
            Destroy(newpipe, 10.0f); // 이전에 생긴 파이프가 10초 뒤 사라짐
        }
    }
}
