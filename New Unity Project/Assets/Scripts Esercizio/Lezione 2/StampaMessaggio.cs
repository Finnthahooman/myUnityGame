using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampaMessaggio : MonoBehaviour
{
    public uint times;
    public string msg;
    // Update is called once per frame
    void Update()
    {
        while (times > 0)
        {
            Debug.Log(msg);
            times--;
        }
            
    }
}
