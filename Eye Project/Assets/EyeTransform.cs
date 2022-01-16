using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class EyeTransform : MonoBehaviour
{
    public Transform target;
    public float movementSpeed = 1f;   //controls moveSpeed of translation
    public float rotationSpeed = 2f;   //controls rotationSpeed of rotation
    
    //values that you want to save
    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        CreateText();
    }
    
    void write(){
        string path = Application.dataPath + "/test.txt";
        StreamWriter writer = new StreamWriter(path,true);
        writer.WriteLine("x: " + x.ToString() + " y: " + y.ToString() + " z: " + z.ToString());
        writer.Close();
    }
    void CreateText(){
        string path = Application.dataPath + "/test.txt";
        if(!File.Exists(path)){
            File.WriteAllText(path,"Test \n\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(0,10f);
        y = Random.Range(20.0f, 20.0f);
        z = Random.Range(20.0f, 20.0f);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(transform.forward * movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-transform.forward * movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W)) {
            transform.Rotate(new Vector3(x, y, z) * rotationSpeed * Time.deltaTime);
        }
    }
}