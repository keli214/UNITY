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
        //if (transform.eulerAngles.x > 180 | transform.eulerAngles.x < 0 |transform.eulerAngles.y > 90 |transform.eulerAngles.y <-90| transform.eulerAngles.z > 90|transform.eulerAngles.z < -90)
          //      transform.rotation = Quaternion.Euler(90, 0, 0);
        if (Input.GetKey(KeyCode.R))//press R to rotate from current position 
            transform.Rotate(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }
}
