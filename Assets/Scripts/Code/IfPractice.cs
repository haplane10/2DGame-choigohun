using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPractice : MonoBehaviour
{
    public int B, A;  // B = 0  A = 0

    int Add(int C, int D)
    {
        return C + D;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var F = Add(A, B);

        if (Add(B, A) > 50)
        {
            Debug.Log("Big");
        }
        else
        {
            Debug.Log("Small");
        }
    }
}
