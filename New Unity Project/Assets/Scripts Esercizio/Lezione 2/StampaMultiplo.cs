using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampaMultiplo : MonoBehaviour
{
    public int var, div;
    // Start is called before the first frame update
    void Start()
    {
        if (var % div == 0)
        {
            Debug.Log(var + " È divisibile per " + div);
        }
    }

}
