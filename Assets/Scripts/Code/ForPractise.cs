using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {//         초기값,  패턴은 +1, 반복횟수 9
     //int sum = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;

        // i = i + 1   ==>   i++
        // i = i - 1   ==>   i--
        
        // i = i + 10  ==>   i += 10
        // i = i - 20  ==>   i -= 20
        // i = i * 10  ==>   i *= 10
        // i = i / 10  ==>   i /= 10

        // x + y + z = z - 2x + 3y  ==> x + y = -2x + 3y

        int sum = 0;
        // for (초기값; 조건식; 즘감식) { 실행 내용 }
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Debug.Log("sum = " + sum);
        }

        // 숙제 :: Factorial?    7!
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
