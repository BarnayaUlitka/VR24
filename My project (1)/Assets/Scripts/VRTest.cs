using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRTest : MonoBehaviour
{
    static public int a;
    static public GameObject Test;
    public int x = 0;
    public Text Mytxt;
    static public int z;
    static public int y;
    static public int c;
    public float[] numbers;
    static public GameObject first;
    private void Start()
    {
        numbers = new float[5] { 1, 2, 3, 6, 9 };
    }

    private void FixedUpdate()
    {
        x++;
        if (x >= 100)
        {
            Test.SetActive(false);
        }
        Mytxt.text = x.ToString();
    }
    public void OnCollisionEnter(Collision collision)
    {
    }

    public void OnTriggerStay(Collider other)
    {
        VRTest.z = Random.Range(0, 255);
        VRTest.c = Random.Range(0, 255);
        VRTest.y = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)x, (byte)y, (byte)c, (byte)z);

    }
}
