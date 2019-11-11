using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MinimiEMassimi : MonoBehaviour
{
    public int[] intarray;
    // Start is called before the first frame update
    void Start()
    {
        intarray = new int[20];
        for (int i = 0; i < intarray.Length; i++)
        {
            intarray[i] = UnityEngine.Random.Range(80, 101);
        }

        int min1 = 0, min2 = 0, min3 = 0, max1 = 0, max2 = 0, max3 = 0;

        for (int i = 0; i < intarray.Length; i++)
        {
            #region Vecchio If
            //if (intarray[i] > max3 && intarray[i] > max2 && intarray[i] > max1)
            //{
            //    if (intarray[i] == max1)
            //    {

            //    }
            //    else
            //    { 
            //        max3 = max2;
            //        max2 = max1;
            //        max1 = intarray[i];
            //    }

            //}
            //else if (intarray[i] > max3 && intarray[i] > max2)
            //{
            //    if (intarray[i] == max2)
            //    {

            //    }
            //    else
            //    { 
            //        max3 = max2;
            //        max2 = intarray[i];
            //    }
            //}
            //else if (intarray[i] > max3)
            //{
            //    if (intarray[i] == max3)
            //    {

            //    }
            //    else
            //    {
            //        max3 = intarray[i];
            //    }
            //}
            #endregion

            if (intarray[i] > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = intarray[i];
            }

        }
        Debug.Log("il 1° numero più alto è: " + max1);
        Debug.Log("il 2° numero più alto è: " + max2);
        Debug.Log("il 3° numero più alto è: "+ max3);

        Array.Sort(intarray);
    }

}
