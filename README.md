# FlappyBird

💛 Unity를 이용한 게임 만들기 연습용 <1>  

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
1:21:35
