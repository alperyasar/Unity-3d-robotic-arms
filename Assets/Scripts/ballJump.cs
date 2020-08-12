using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpObstacle : MonoBehaviour
{

    private float jumpForce = 100f;
    private Rigidbody2D rb;
    private bool isGrounded; // Check if obstacle touch the ground


    // Use this for initialization
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isGrounded == true)
        {
            rb.AddForce(transform.up * jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "box") // you must add collider to ground 
        {
            isGrounded = true;
        }
    }


}