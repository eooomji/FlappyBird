# FlappyBird

💛 Unity를 이용한 게임 만들기 연습용 <1>  

📌 추가로 해볼 것 (생각나는 즉시 적어보자)  
1. 마우스 왼쪽 버튼 클릭이 아닌, 스페이스바로 점프하기  
2. Speed도 고정하지말고, 랜덤으로 변화해주기  
3. 새가 하늘 뚫지 않게 설정  
4. Game Logic 바꿔보기  

📌 정리  

💡 Debug.Log(변수명);  
C의 printf, JS의 console.log()와 같이, Unity 콘솔창에 찍을 때 사용  

💡 Frame : 게임마다 똑같은 게 아니고, 컴퓨터나 스마트폰의 성능에 따라 달라짐  
- 6FPS = 1초에 6m  
- 3FPS = 1초에 3m  
=> 모든 사용자들에게 똑같도록 맞춰줘야 함 = " Time.deltaTime " : 지난 프레임이 완료되는 데까지 걸린 시간 (FPS 보정용으로 사용)  
ex) 6FPS에는 * 1/6, 3FPS에는 * 1/3  

💡 Component  
- Box Collider 2D : 하나의 물체로 인식함 (통과할 수 없음)  
- Frefab : 오브젝트를 하나만 만들어 놓고, 여러 번 쓸 때 Frefab으로 만들고, Generator를 사용해 여러 개 생산해냄  
🚨 Object를 Frefab으로 만드는 방법❓  
=> Object 파일을 Assets 폴더 안에 Drag & Drop => 빈 오브젝트 아이콘이 파란색으로 채워짐!  
++) Hierarchy 안의 최초로 만든 Frefab을 지워도, 에셋에 남아있어 영구 사용 가능  
🚨 그럼 Generator는 어떻게 만드나요❓   
=> 빈 Object file을 생성하고, Script에서 생성하도록 만들어줌  
🚨 본 Frefab의 속성으로, 만들어지는 Frefab에도 반영은 어떻게 하나요❓   
=> Inspector -> Overrides - > Apply All  💧 난 왜 안 뜨지...?ㅎㅎ;;  
- Collider (Collider(ex, Box - Capsule)끼리 충돌 할 때)  
 1) Collision (기본) : 벽으로 인식  
 2) Trigger : 관통 가능  
 => 충돌 시 : OnCollision or OnTrigge(-Enter, -Exit)  

💡 Class   
- Random.Range(a.0f, b.0f) : a.0f ~ b.0f 범위 중 랜덤으로 할당  

💡 UI 요소 (text, button 등)  
- 바로 GameObject를 생성하는 것이 아닌, 부모 오브젝트로 canvas를 만들고, 그 안에 UI 요소를 넣어줌  
- Inspector -> Canvas -> Render Mode "Screen Space - Overlay"  
  : 스마트폰의 사이즈에 따라 화면 크기가 다른데, Screen Space - Overlay로 설정해주면 어느 화면에 맞추지 않고, 꽉 채움!  
- Text -> Inspector -> Rect Transform  
  : 화면 크기에 상관없이, 특정 점(Anchor)을 기준으로 위치를 지정하는 것  
  : Anchor (min(0,0), max(1, 1))로 설정  
- Button  
🚨 OnClick 사용법❓   
=> Button -> Inspector -> Button을 보면 OnClick()이 이미 내장되어 있음.  
=> 따라서, OnClick 때 발생할 함수를 만들고 싶으면, 빈 Object를 하나 생성하고 그 오브젝트 하단에 스크립트를 추가. 스크립트에서 함수 생성  
=> 아까 OnClick() 안에, 생성한 빈 Object를 넣고, 오른쪽에서 실행시킬 함수를 고르면 끝!  
  
💡 Scene을 여러 개 쓰는 경우
- (코드) SceneManager.LoadScene("Scene 이름");
- (Unity) File -> Build Setting -> Scenes In Build에 Scene을 Drag & Drop (이때, 오른쪽 번호는 Load되는 순서임)  
