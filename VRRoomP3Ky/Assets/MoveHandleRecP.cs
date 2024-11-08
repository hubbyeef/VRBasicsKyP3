using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHandleRecP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateToPlay()
    {
        transform.Rotate(0, 55, 0);
    }

    public void RotateToStop()
    {
        transform.Rotate(0,-55,0);
    }
}
