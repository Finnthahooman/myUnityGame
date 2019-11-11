using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 30; i++)
        {

            if (i % 2 == 0 && i % 3 == 0)
            {
                Messaggio("FizzBuzz");
            }
            else if (i % 2 == 0)
            {
                Messaggio("Fizz");
            }
            else if (i % 3 == 0)
            {
                Messaggio("Buzz");
            }
            else
            {

            }
        }
    }

    void Messaggio(string msg)
    {

        Debug.Log(msg);

    }
}
