# YuhanTalk

# 소개
본 프로젝트는 TCP 소켓통신과 DB를 이용하여 채팅프로그램을 만드는것을 목표로 하였습니다.

사용 언어 및 개발 환경은 다음과 같습니다.

* 개발 언어 : C# .NET 5.0
* 개발 환경 : Windows Form, Windows OS, Oracle Database 19c

<br><br><br>

# 로그인 및 회원가입
![image](https://user-images.githubusercontent.com/80028960/206930479-a6b6294a-a279-4924-879f-950c2df4bf69.png)
<br>
로그인과 회원가입입니다.<br>
회원가입을 진행한 아이디를 이용하여 로그인을 할 수 있습니다.<br>
<br>

# 메인 화면
![image](https://user-images.githubusercontent.com/80028960/206930569-3376786a-e252-42ca-a8dd-0a73f48f5c8e.png)
<br>
메인 화면입니다. 로그인을 통해 들어올 수 있습니다. <br>
입장시 서버로부터 사용자가 참여하고 있는 채팅방의 목록을 수신받아 표시합니다.<br>
상단의 채팅방 개설버튼을 통해 채팅방을 추가할 수 있습니다.<br>
<br>

# 채팅방 개설 화면
![image](https://user-images.githubusercontent.com/80028960/206930898-6215187d-4edd-4075-a10d-22622ed3374a.png)
<br>
참가할 사용자의 아이디를 입력하여 등록할 수 있습니다. <br>
이때, 없는 사용자의 아이디를 입력할 경우 오류가 표시됩니다.<br>
등록을 모두 마친뒤 생성버튼을 통해 채팅방을 개설합니다.<br>
<br>

# 채팅방 화면
![image](https://user-images.githubusercontent.com/80028960/206930445-14d50380-bc4d-4263-802d-5bb67c2514c1.png)
<br>
채팅방 화면입니다. 메인화면에서 채팅방을 눌러 들어올 수 있으며, 새로운 윈도우 창에서 열리게 됩니다.<br>
입장시 서버로부터 채팅방의 모든 채팅 내역을 받아 표시하게 됩니다.<br>
입력창에 보낼 메시지를 작성 후 엔터키를 눌러 사용자들에게 전송할 수 있습니다.<br>


# 목표
현재 이 프로그램은 SQL Injection 공격에 취약합니다. <br>
보안 분야를 공부하여 SQL Injection 공격을 비롯한 다른 공격에도 방어할 수 있도록 하는것이 목표입니다.
