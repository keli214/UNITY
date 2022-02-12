using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomRotateNew : MonoBehaviour
{
    private float x = 0;
    private float y = 0;
    private float z = 0;
    private float rotationSpeed = 0.3f;

    private Vector3 currentAngles;

    private Vector3 targetAngles;
    private float xDirection = 1;
    private float zDirection = 1;
    private int count = 0;
    private int reset = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        QualitySettings.vSyncCount= 0;
        Application.targetFrameRate = 60;
        CreateText();
        currentAngles = new Vector3(0f,0f,0f);
        transform.eulerAngles = currentAngles;
        // Debug.Log(transform.eulerAngles);
    }
    void write()
    {
        string path = Application.dataPath + "/test.txt";
        StreamWriter writer = new StreamWriter(path, true);
        // writer.WriteLine("x: " + x.ToString() + " y: " + y.ToString() + " z: " + z.ToString());
        writer.WriteLine("currentAngles: " + currentAngles);
        writer.Close();
    }
    void CreateText()
    {
        string path = Application.dataPath + "/test.txt";
        File.WriteAllText(path, "Test \n\n");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(reset == 0) targetAngles = new Vector3(44f,0,0);
        //Debug.Log(targetAngles);
        count ++;
        reset ++;
        //reset count
        if(count > 60){
            count = 0;
        }
        if(reset == 3600) reset = 0;
        //Debug.Log(xDirection);
        if(currentAngles.x > 26 && currentAngles.x < 27) xDirection = -1;
        if(currentAngles.x > -44 && currentAngles.x < -43) xDirection = 1;
        if(currentAngles.z > 43 && currentAngles.z < 44) zDirection = -1;
        if(currentAngles.z > -40 && currentAngles.z < -39) zDirection = 1;
        
        x = rotationSpeed*xDirection + x;
        z = rotationSpeed*zDirection + z;
        y = 0f;
        currentAngles = new Vector3(x,y,z);
        transform.eulerAngles = currentAngles;
        // if(count == 60){
          write();
        //}
        
    }
}
