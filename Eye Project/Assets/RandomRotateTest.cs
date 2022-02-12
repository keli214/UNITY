using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomRotateTest : MonoBehaviour
{
    private float x = 0;
    private float y = 0;
    private float z = 0;

    private float rotationSpeed = 10;

    private float direction = 1;

    private float xDirection = 1;

    private float yDirection = 1;
    private float zDirection = 1;
    private float yLimit = 0.1f;

    private Vector3 startAngles;
    private bool test = true;
    private int count = 0;
    private int reset = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        QualitySettings.vSyncCount= 0;
        Application.targetFrameRate = 60;
        CreateText();
        startAngles = new Vector3(0f,0f,0f);
        transform.eulerAngles = startAngles;
        // Debug.Log(transform.eulerAngles);
    }
    void write()
    {
        string path = Application.dataPath + "/test.txt";
        StreamWriter writer = new StreamWriter(path, true);
        // writer.WriteLine("x: " + x.ToString() + " y: " + y.ToString() + " z: " + z.ToString());
        writer.WriteLine("EulerAngles: " + transform.eulerAngles);
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
        count ++;
        reset ++;
        //reset count
        if(count > 60){
            count = 0;
        }
        //Debug.Log()
        if(transform.eulerAngles.x > 26 && transform.eulerAngles.x < 27) xDirection = -1;
        if(transform.eulerAngles.x > 321 && transform.eulerAngles.x < 322) xDirection = 1;
        if(transform.eulerAngles.z > 43 && transform.eulerAngles.z < 44) zDirection = -1;
        if(transform.eulerAngles.z > 320 && transform.eulerAngles.z < 321) zDirection = 1;
        // if(transform.eulerAngles.y > 302 && transform.eulerAngles.y < 303) yDirection = -1;
        // if(transform.eulerAngles.y > 298 && transform.eulerAngles.y < 299) yDirection = 1;
        if(transform.eulerAngles.y > 0 && transform.eulerAngles.y < 1) yDirection = -1;
        if(transform.eulerAngles.y > 356 && transform.eulerAngles.y < 367) yDirection = 1;
        transform.Rotate(Time.deltaTime * rotationSpeed * xDirection, Time.deltaTime * rotationSpeed * xDirection , Time.deltaTime * rotationSpeed * zDirection, Space.Self);
        // if(count == 60){
          write();
        // }
        
    }
}
