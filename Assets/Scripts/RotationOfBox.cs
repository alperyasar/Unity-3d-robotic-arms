using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfBox : MonoBehaviour
{
    //  public Transform upperArm1;
    // Start is called before the first frame update
    float temp1;
    float temp2;
    float temp3;
    float temp4;
    Vector3 position1;
    Vector3 position2;
    Vector3 position3;
    Vector3 position4;
    void Start()
    {
        position1 = GameObject.FindGameObjectWithTag("upperArm1").transform.position;
        temp1 = position1.y;
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;
        temp2 = position2.y;
        position3 = GameObject.FindGameObjectWithTag("upperArm3").transform.position;
        temp3 = position3.y;
        position4 = GameObject.FindGameObjectWithTag("upperArm4").transform.position;
        temp4 = position4.y;
    }

    // Update is called once per frame
    void Update()
    {
        position1 = GameObject.FindGameObjectWithTag("upperArm1").transform.position;
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;   
        position3 = GameObject.FindGameObjectWithTag("upperArm3").transform.position; 
        position4 = GameObject.FindGameObjectWithTag("upperArm4").transform.position;

        if (position1.y != temp1)
            rotateArm1();
      /*  if (position2.y != temp2)
            rotateArm2();*/
        if (position3.y != temp3)
            rotateArm3();
     /*   if (position4.y != temp4)
            rotateArm4();*/
    }
    void rotateArm1()
    {


        if (temp1 > position1.y)
        {
            transform.Rotate(Vector3.right, 2*(temp1 - position1.y));
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x,position2.y + (temp1 - position1.y), position2.z);
        }
        else if (temp1 < position1.y)
        {
            transform.Rotate(Vector3.left, 2 * (position1.y - temp1));
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y - (position1.y - temp1), position2.z);
        }
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;

        temp2 = position2.y;
        Debug.Log(position2.y + "-" + temp2);
        temp1 = position1.y;

    }/*
    void rotateArm2()
    {
        Debug.Log("sikik");
        Debug.Log(position2.y + "-" + temp2);
        if (temp2 > position2.y)
        {
            transform.Rotate(Vector3.left, 2 * 2 * (temp2 - position2.y));
        }
        else if (temp2 < position2.y)
        {
            transform.Rotate(Vector3.right, 2 * (position2.y - temp2));
        }
        temp2 = position2.y;

    }*/
    void rotateArm3()
    {


        Debug.Log(position3.y + "," + temp3);
        if (temp3 > (int)position3.y)
        {
            transform.Rotate(Vector3.down, 2 * (temp3 - position3.y));
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y + (temp3 - position3.y), position4.z);
        }
        else if (temp3 < (int)position3.y)
        {
            transform.Rotate(Vector3.up, 2 * (position3.y - temp3));
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y - (position3.y - temp3), position4.z);
        }
        position4 = GameObject.FindGameObjectWithTag("upperArm4").transform.position;

        temp4 = position4.y;
        Debug.Log(position4.y + "-" + temp4);
        temp3 = position3.y;

    }/*
    void rotateArm4()
    {


        Debug.Log(position4.y + "," + temp4);
        if (temp4 > (int)position4.y)
        {
            transform.Rotate(Vector3.up, 2 * ((int)temp4 - (int)position4.y));
        }
        else if (temp4 < (int)position4.y)
        {
            transform.Rotate(Vector3.down, 2 * ((int)position4.y - (int)temp4));
        }
        temp4 = (int)position4.y;

    }*/
}
