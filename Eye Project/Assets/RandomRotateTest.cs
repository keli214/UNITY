using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomRotateTest : MonoBehaviour
{
    private float x = 0;
    private float y = 0;
    private float z = 0;
    private bool test = true;
    private int count = 0;
    private int reset = 0;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount= 0;
        Application.targetFrameRate = 60;
        CreateText();
    }
    void write()
    {
        string path = Application.dataPath + "/test_50.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("x: " + x.ToString() + " y: " + y.ToString() + " z: " + z.ToString());
        writer.WriteLine("EulerAngles: " + transform.eulerAngles);
        writer.Close();
    }
    void CreateText()
    {
        string path = Application.dataPath + "/test_50.txt";
        File.WriteAllText(path, "Test \n\n");
        
    }

    // Update is called once per frame
    void Update()
    {
        count ++;
        reset ++;
        if(count > 60){
            count = 0;
        }
        if(reset == 1200){
            transform.eulerAngles = new Vector3(0,0,0);
            reset = 0;
        }
        if(count == 20){
            if(test){
                y = -2f;
                z = -2f;
                x = 10f;
                test = false;
            }
            else{
                y = 2f;
                z = 2f;
                x = -10f;
                test = true;
            }
            transform.Rotate(new Vector3(x, y, z));
        }
        else if(count == 40){
            
            if(test){
                x = -2f;
                z = -2f;
                y = 10f;
                test = false;
            }
            else {
                x = 2f;
                z = 2f;
                y = -10f;
                test = true;
            }
            transform.Rotate(new Vector3(x, y, z));
        }
        else if(count == 60){
            if(test){
                x = -2f;
                y = -2f;
                z = 10f;
                test = false;
            }
            else {
                x = 2f;
                y = 2f;
                z = -10f;
                test = true;
            }
            transform.Rotate(new Vector3(x, y, z));
        }
        if(count == 20 || count == 60 || count == 40){
            write();
        }
        
    }
}
