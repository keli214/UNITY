using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomRotate : MonoBehaviour
{
    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        CreateText();
    }
    void write()
    {
        string path = Application.dataPath + "/test.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("x: " + x.ToString() + " y: " + y.ToString() + " z: " + z.ToString());
        writer.Close();
    }
    void CreateText()
    {
        string path = Application.dataPath + "/test.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Test \n\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.eulerAngles.x > 180 | transform.eulerAngles.x < 0 |transform.eulerAngles.y > 90 |transform.eulerAngles.y <-90| transform.eulerAngles.z > 90|transform.eulerAngles.z < -90)
        //      transform.rotation = Quaternion.Euler(90, 0, 0);
        if (Input.GetKey(KeyCode.R)) //press R to rotate from current position 
        {
            x = Random.Range(-1f, 1f);
            y = Random.Range(-1f, 1f);
            z = Random.Range(-1f, 1f);
            transform.Rotate(x, y, z);
            write();
        }
    }
}
