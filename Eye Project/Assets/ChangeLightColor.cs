using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightColor : MonoBehaviour
{
    public float rValue;
    public float gValue;
    public float bValue;
    public float brightness;
    Light lt;

    public void Bright(float Brightness)
    {
        brightness = Brightness;
    }
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
        rValue = 1f;
        gValue = 1f;
        bValue = 1f;
        brightness = 0f;
        // newColor = new Color(rValue,gValue,bValue);
        lt.color = new Color(rValue,gValue,bValue);
    }

    // Update is called once per frame
    public void Update()
    {
        // newColor = new Color(rValue, gValue, bValue);
        lt.color = new Color(rValue*(brightness), gValue*(brightness),bValue*(brightness));
    }

}
