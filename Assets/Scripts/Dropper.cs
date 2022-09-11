using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    float fltTimeToWait = 5f;

    // Update is called once per frame
    void Update()
    {
        // I would instead take a snapshot of the time once, add the time to it, then when time >= time.time then drop it.
        if(Time.time  >fltTimeToWait)
        {
            Debug.Log($"{fltTimeToWait} seconds has passed");
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
