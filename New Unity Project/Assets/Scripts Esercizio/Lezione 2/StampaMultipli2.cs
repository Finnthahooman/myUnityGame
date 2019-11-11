using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampaMultipli2 : MonoBehaviour
{
    public int divisore, min, max;
    // Start is called before the first frame update
    void Start()
    {
        for (; min <= max; min++)
        {
            if (divisore % min == 0)
            {
                Debug.Log(min + " È multiplo di " + divisore);
            }
        }
    }
}

