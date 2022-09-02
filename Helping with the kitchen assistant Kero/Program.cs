// 케로는 필요한 음식을 가져다준다.
// 케로의 창고에는 n개의 재료를 지정된 순서로 저장되어있다. 같은 재료가 여러개 있을 수 도 있다.
// 케로는 재료가 저장된 배열의 순서도를 갖고 있다.
// 
// 기계에서 음식을 가져오는 방법은 한가지를 선택하고 원하는 재료가 선택이 안되어있으면 1코인을 지불해서 다음재료로 넘어간다.
// 왼쪽으로 한칸 혹은 오른쪽으로 한칸 선택 가능
// 첫번째 재료의 왼쪽은 마지막 재료로 간주되고 마지막 재료의 오른쪽은 첫번째 재료로 간주된다. (원형구조)
// 케로가 올바른 재료를 가져오려면 드는 최소비용을 계산하는 함수를 만들어라


// [예시]
// ingredients = ['linguine', 'pepper', 'ketchup', 'mushroom']
// startIndex = 1
// target = 'linguien'

// 창고에 선택되어있는 재료는 현재 인덱스 1에 있는 pepper임
// 케로가 필요한 재료는 0번인덱스의 linguine임
// 케로는 오른쪽으로 3번움직여서 3코인을 지불하거나 왼쪽으로 1번 움직여서 1코인을 지불하면 원하는 재료를 얻는다. 그러므로 1코인이 최소비용이다.


// [Function Description]
// solution 함수의 인자는 아래와 같다.
// str ingredients[n]: 재료의 순서를 알려주는 문자배열 [1 <= n <= 100]
// int startIndex: 현재 어떤 재료가 선택되어 있는지 알려주는 정수 [0 <= startIndex <= n-1]
// str target: 필요한 재료를 나타내는 문자열 


class VendingMachine
{
   
        
    static void Calculator(string[] ingredients, int startIndex, string target)
    {
        
    }
    static void Main(string[] args)
    {
        string[] ingredients = { "linguine", "pepper,", "ketchup", "mushroom" };
        int startIndex = 0;
        string target = ingredients[2];

        int tempIndex = startIndex;
        int costToRight = 0;
        int costToLeft = 0;

        while ( true )
        {
            if (target == ingredients[tempIndex])
            {
                break;
            }

            tempIndex++;

            if (tempIndex >= ingredients.Length)
            {
                tempIndex = 0;
            }

            costToRight++;
        }

        tempIndex = startIndex;

        while (true)
        {
            if (target == ingredients[tempIndex])
            {
                break;
            }

            tempIndex--;

            if (tempIndex < 0 )
            {
                tempIndex = ingredients.Length - 1;
            }

            costToLeft++;
        }

        int minCost = Math.Min(costToLeft, costToRight);



    }

     
        




   
}



