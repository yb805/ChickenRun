# ChickenRun
게임이름: Chicken Run

게임 컨셉: 주인공인 꼬꼬가 닭장을 탈출해 인간들이 설치한 덫과 숲속의 몬스터를 피해 안전한 곳으로 가야하는 생존게임 


주인공 스토리: 평생을 닭장에서 살아온 꼬꼬, 이젠 세상 밖이 궁금하다. 그러던 어느날 열린 닭장 문을 보게 되는데..
닭장 밖을 나왔지만, 세상은 호락호락 하지않다! 과연 꼬꼬는 안전하게 탈출할 수 있을 것인가?

게임진행 방법 : 
- asdw 키를 누르면 꼬꼬가 상하좌우 이동을 한다. 
- 루트를 따라 이동하면서 설치된 덫과 몬스터를 피한다. 
- 덫과 몬스터의 충돌시 hp 1씩 감소. 
- 음식(포션역할) 과 충돌시 hp 1씩 증가 
- 최대 hp 수치인 10이 다 깎이면 GAMEOVER
- 끝까지 생존해 최종 목적지에 도달하면 GAMECLEAR
  

제작 스크립트 :

- 치킨 컨트롤러 : 꼬꼬의 좌우이동, 방향전환, 충돌감지 
- 카메라 컨트롤러 : 꼬꼬를 따라 다니도록 고정 
- hp 컨트롤러 : UI이미지 연결, 충돌시 체력감소, 증가 
- 씬 전환 : 시작씬, 게임오버씬, 종료씬 각각의 씬 전환 
- 몬스터 컨트롤러 : 랜덤으로 좌우이동하도록 설정 

![image](https://user-images.githubusercontent.com/84612961/120946418-64234200-c777-11eb-8b5d-66be73d04ef9.png)
주인공 꼬꼬 에셋

![image](https://user-images.githubusercontent.com/84612961/120946457-8ae17880-c777-11eb-88e5-9618165af134.png)
덫 에셋

![image](https://user-images.githubusercontent.com/84612961/120946478-a0ef3900-c777-11eb-94b6-ff1615fdd5c0.png)
배경에셋

![image](https://user-images.githubusercontent.com/84612961/120946492-b19faf00-c777-11eb-9a5f-34aea5ac3a06.png)
몬스터 에셋

![image](https://user-images.githubusercontent.com/84612961/120946522-c2e8bb80-c777-11eb-8d1e-e0a5f24c57ab.png)
포션 에셋
