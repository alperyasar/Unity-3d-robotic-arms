using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelator : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(Input.acceleration);
    }
}
