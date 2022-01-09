using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTransform : MonoBehaviour
{
    public Transform target;
    public float movementSpeed = 1f;        //controls moveSpeed of translation
    public float rotationSpeed = 50f;   //controls rotationSpeed of rotation
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(transform.forward * movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-transform.forward * movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}