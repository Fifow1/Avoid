# 365 Minutes
 피하기 게임
 2024/12/23 ~ 2024/12/27 (총 5일)


## 클래스 다이어 그램
<img width="631" alt="image" src="https://github.com/user-attachments/assets/16cc59d8-6779-4919-8993-a307cb17f270" />

 
## 기능
 1. 게임 시작 종료
 2. 사용자 입력 처리 - W , A , S , D 로 캐릭터 움직임 처리
 3. 플레이어 상태 출력 (플레이어 목숨 , 버틴 시간)
 4. 시간이 지남에 따라 총알 나오는 벽의 개수 추가
 5. 목숨이 0보다 작아지면 패배 (기본 목숨 3개 , 총알에 닿으면 목숨 -1)
 6. 44초를 버티면 승리


## 흐름
 1. 게임 시작 화면
 2. 입력에 따른 플레이어 이동(맵 안에서)
 3. 11 초가 지날 때마다 총알 나오는 벽의 개수 추가
 4. 44초 버티면 승리 화면 출력
 5. 44초 전에 목숨이 0개가 된다면 실패 화면 출력


## 사용 데이터 구조
 * Struct : 이전 플레이어의 위치
 * CLass : 플레이어 , 총알 , 총알 관리

## 클래스 설계 
 * Player : 플레이어 x 좌표 , y 좌표 , 목숨 , 이동 메서드
 * Bullet : 총알 x,y 좌표
 * Bullet Manager : 총알 배열

