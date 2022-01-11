using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            transform.rotation = Quaternion.Euler(Random.Range(45, 135), Random.Range(-45, 45), Random.Range(-45, 45));
    }
}
