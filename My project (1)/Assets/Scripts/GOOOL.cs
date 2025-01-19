using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GOOOL : MonoBehaviour
{
    public int x = 0;
    public GameObject Test;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        x++;
        if (x >= 100)
        {
            Test.SetActive(false);
        }
    }
}
