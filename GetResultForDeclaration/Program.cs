
// 불량이용자 신고처리 메일링 시스템

// 1. 각 유저는 한번에 한명의 유저를 신고할 수 있다.
// 2. 신고 횟수에 제한은 없고 다른유저를 계속 신고할 수 있다.
// 3. 한 유저를 여러번 신고할 수는 있지만 1회로 처리된다.
// 4. k번이상 신고를 받은 유저는 게시판 이용이 정지된다.
// 5. 해당유저를 신고한 모든 유저에게 정지사실을 메일로 발송한다.
// 6. 유저가 신고한 모든 내용을 취합해서 마지막에 한꺼번에 게시판 이용정지를 시키며 정지 메일을 발송한다.


// 예
// ["Muzi", "Frodo", "Apeach", "Neo"] k = 2 (2회이상 신고시 정지)

using System;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[] { };
        return answer;
    }
}
