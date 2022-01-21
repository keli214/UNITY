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
        //if (transform.eulerAngles.x > 180 | transform.eulerAngles.x < 0 |transform.eulerAngles.y > 90 |transform.eulerAngles.y <-90| transform.eulerAngles.z > 90|transform.eulerAngles.z < -90)
        //      transform.rotation = Quaternion.Euler(90, 0, 0);
        // if (Input.GetKey(KeyCode.R)) //press R to rotate from current position 
        // {
        count ++;
        reset ++;
        if(count > 60){
            count = 0;
        }
        if(reset == 1200){
            transform.localEulerAngles = new Vector3(90f,0,0);
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
