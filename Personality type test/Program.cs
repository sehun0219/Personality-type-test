

// 성격 유형 검사지를 만들려고 한다.
// 성격은 4개의 지표로 성격 유형을 구분한다. 성격은 각 지표에서 두 유형중 하나로 결저오딘다.

// 1번지표 R형 T형
// 2번지표 C형 F형
// 3번지표 J형 M형
// 4번지표 A형 N형

// 검사결과는 질문의 성격유형점수를 더해서 지표에 더 높은 점수를 받은 성격 유형이 검사자의 유형이된다.
// 점수가 같게나오면 두 성격 유형중 사전 순으로 빠른 성격 유형을 검사자의 성격유형이라고 판단한다. 

// 질문마다. 판단지표를 담은 1차원 배열이름은 survey 
// 선택한 선택지를 담은 1차원 정수배열 choices
// 지표번호 순서대로 결과를 리턴하는 함수를 만들어라


using System;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        int R = 0, T = 0, C = 0, F = 0, J = 0, M = 0, A = 0, N = 0;
        int length = survey.Length;
        for (int i = 0; i < length; i++)
        {
            switch (survey[i])
            {
                case "RT": scoreCheck(choices[i], ref R, ref T); break;
                case "TR": scoreCheck(choices[i], ref T, ref R); break;
                case "FC": scoreCheck(choices[i], ref F, ref C); break;
                case "CF": scoreCheck(choices[i], ref C, ref F); break;
                case "MJ": scoreCheck(choices[i], ref M, ref J); break;
                case "JM": scoreCheck(choices[i], ref J, ref M); break;
                case "AN": scoreCheck(choices[i], ref A, ref N); break;
                case "NA": scoreCheck(choices[i], ref N, ref A); break;
            }
            
        }
        string answer = " ";
        answer += personaCheck(R, T, "RT");
        answer += personaCheck(C, F, "CF");
        answer += personaCheck(J, M, "JM");
        answer += personaCheck(A, N, "AN");

        return answer;
    }
    private void scoreCheck(int s, ref int a, ref int b)
    {
        switch (s)
        {
            case 1: a += 3; break;
            case 2: a += 2; break;
            case 3: a += 1; break;
            case 4: break;
            case 5: a += 1; break;
            case 6: a += 2; break;
            case 7: a += 3; break;

        }
    }
    private string personaCheck(int a, int b, string str)
    {
        if (a == 0 && b == 0)
        {
            return str.Substring(0, 1);
        }
        if (a >= b)
        {
            return str.Substring(0, 1);
        }
        return str.Substring(1, 1);
    }
}

