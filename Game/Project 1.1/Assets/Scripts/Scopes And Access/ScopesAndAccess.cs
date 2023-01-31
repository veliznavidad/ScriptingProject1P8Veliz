using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopesAndAccess : MonoBehaviour
{
    public int alpha = 3;

    private int beta = 0;
    private int gamma = 1;

    private AnotherClass myOtherClass;

    void start()
    {
        alpha = 2;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);

    }
    
    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
