using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightColor : MonoBehaviour
{
    public float rValue;
    public float gValue;
    public float bValue;
    private Color newColor;
    Light lt;
    public void Red(float Redvalue)
    {
        rValue = Redvalue;
    }
    public void Green(float Greenvalue)
    {
        gValue = Greenvalue;
    }
    public void Blue(float Bluevalue)
    {
        bValue = Bluevalue;
    }
    // Start is called before the first frame update
    public void Start()
    { 
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    public void Update()
    {
        newColor = new Color(rValue, gValue, bValue);
        lt.color = newColor;
    }
}
