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
        if (transform.position.y > 22)
            transform.position = new Vector3(x, 22f, z);
        else if (transform.position.y < 16)
            transform.position = new Vector3(x, 16f, z);
        else
            transform.position = new Vector3(x, transform.position.y, z);
    }
}
