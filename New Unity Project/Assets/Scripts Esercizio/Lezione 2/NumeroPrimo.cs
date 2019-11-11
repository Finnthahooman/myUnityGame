using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroPrimo : MonoBehaviour
{
    public int var;
    // Start is called before the first frame update
    void Start()
    {

        int count = 0;

        for (int i = 1; i <= var; i++)
        {
            if (var % i == 0)
            {

                count++;
               
            }

        }

        if (count == 2)
        {
            Debug.Log(var + " È un numero primo");
        }


       
    }

}
