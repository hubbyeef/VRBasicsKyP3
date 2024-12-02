using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHand;
    public static DateTime Now = DateTime.Now;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DateTime.Now);
        secondHand.transform.rotation = Quaternion.Euler((Now.Second * 6) + 90, 0, -90);
        minuteHand.transform.rotation = Quaternion.Euler((Now.Minute * 6) + 90, 0, -90);
        hourHand.transform.rotation = Quaternion.Euler((Now.Hour * 30) + 90, 0, -90);
    }

    // jason you should kill yourself you dont deserve life or love
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // FixedUpdate is called 50 times a second.
        // Each minute and second makes 6 degrees
        secondHand.transform.Rotate(0, 0.12f, 0);
        minuteHand.transform.Rotate(0, 0.002f, 0);
        hourHand.transform.Rotate(0, 0.000033333333f, 0);
    }
}
