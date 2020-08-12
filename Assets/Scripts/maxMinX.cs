using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxMinX : MonoBehaviour
{
    // Start is called before the first frame update
    float x;
    float z;
    void Start()
    {
        x = transform.position.x;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 23f)
            transform.position = new Vector3(x, 23f, z);
        else if (transform.position.y < 19f)
            transform.position = new Vector3(x, 19f, z);
        else
            transform.position = new Vector3(x, transform.position.y, z);
    }
}
