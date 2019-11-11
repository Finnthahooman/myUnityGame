using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 30; i++)
        {
            #region Lo Switch non funziona 
            //switch (i)
            //{
            //    case (i % (int)3 == 0):

            //        break;

            //}
            #endregion

            if (i % 2 == 0 && i % 3 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 2 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {

            }
        }
    }

}
