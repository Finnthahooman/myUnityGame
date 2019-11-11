using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampaPari : MonoBehaviour
{
    public int var;
    // Start is called before the first frame update
    void Start()
    {
        if ((var % 2) == 0)
        {
            Debug.Log(var + " È pari!");
        }
    }
}
