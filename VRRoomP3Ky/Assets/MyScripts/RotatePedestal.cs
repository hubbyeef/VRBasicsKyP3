using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePedestal : MonoBehaviour
{
    public GameObject pedestal;
    public Slider slider;
    public float speed;
    public float maxRotation = 180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, (180 * slider.value), 0);
    }
}
