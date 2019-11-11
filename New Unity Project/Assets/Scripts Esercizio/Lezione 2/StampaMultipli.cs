using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampaMultipli : MonoBehaviour
{
    public int divisore;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i <= 30; i++)
        {
            if (divisore % i == 0)
            {
                Debug.Log(i + " È multiplo di " + divisore);
            }
        }
    }
}

