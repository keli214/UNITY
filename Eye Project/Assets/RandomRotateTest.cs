using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomRotateTest : MonoBehaviour
{
    private float x = 0;
    private float y = 0;
    private float z = 0;
    private bool test1 = true;
    private bool test2 = true;

    private bool test3 = true;
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
        string path = Application.dataPath + "/test.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("x: " + x.ToString() + " y: " + y.ToString() + " z: " + z.ToString());
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
        if(count > 40){
            count = 0;
        }
        if(reset == 300){
            transform.eulerAngles = new Vector3(0,0,0);
            reset = 0;
        }
        if(reset != 0 && count == 20){
            if(!test1){
                y = 0f;
                z += -5f;
                x += -3f;
                test1 = true;
            }
            else{
                y = 0f;
                z += 3f;
                x += 5f;
                test1 = false;
            }
            transform.eulerAngles = new Vector3(x, y, z);
        }
        else if(reset != 0 && count == 40){
            if(!test3){
                y = 0f;
                z += -8f;
                x += -6f;
                test3 = true;
            }
            else{
                y = 0f;
                z += 6f;
                x += 8f;
                test3 = false;
            }
            transform.eulerAngles = new Vector3(x, y, z);
        }
        else if(reset != 0 && count == 60){
            if(!test2){
                x += 3f;
                y = 0f;
                z += 10f;
                test2 = true;
            }
            else{
                x += -3f;
                y = 0f;
                z += -10f;
                test2 = false;
            }
            transform.eulerAngles = new Vector3(x, y, z);
        }
        if(count == 20 || count == 40 ||count == 60){
            write();
        }
        
    }
}
