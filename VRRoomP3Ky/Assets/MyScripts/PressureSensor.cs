using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PressureSensor : MonoBehaviour
{
    public int counter;
    public TextMeshProUGUI counterUI;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            counter++;
            UpdateText();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            counter--;
            UpdateText();
        }
    }

    private void UpdateText()
    {
        counterUI.text = "Total Boxes: " + counter;
    }
}
