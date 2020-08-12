using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfBox : MonoBehaviour
{
    //  public Transform upperArm1;
    // Start is called before the first frame update
    public int purpose = 1;
    int upDown = 1, i = 0;
    int turnBack1, turnBack2;
    float temp1, temp3;
    Vector3 position1, position2, position3, position4;
    Vector3 ball, box;
    void Start()
    {
        position1 = GameObject.FindGameObjectWithTag("upperArm1").transform.position;
        temp1 = position1.y;
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;
        position3 = GameObject.FindGameObjectWithTag("upperArm3").transform.position;
        temp3 = position3.y;
        position4 = GameObject.FindGameObjectWithTag("upperArm4").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position1 = GameObject.FindGameObjectWithTag("upperArm1").transform.position;
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;
        position3 = GameObject.FindGameObjectWithTag("upperArm3").transform.position;
        position4 = GameObject.FindGameObjectWithTag("upperArm4").transform.position;
        ball = GameObject.FindGameObjectWithTag("ball").transform.position;
        box = GameObject.FindGameObjectWithTag("box").transform.position;

        if (purpose == 1)
        {
            if (box.y > 21.5f || ball.y - box.y > 3.2f)
                upDown = 2;
            else if (box.y < 19.3f)
                upDown = 1;
            if (ball.y - box.y < 3.2f && upDown==1)
                jumpUp();
            else if (upDown == 2)
                jumpDown();



        }
        
        else if (purpose == 2)
        {
            if (position1.y != temp1)
                rotateArm1();
            if (position3.y != temp3)
                rotateArm3();
        }



    }
    void jumpUp()
    {
        rotateWithJump1();
        rotateWithJump2();
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y + (30f * Time.deltaTime), position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y + (30f * Time.deltaTime), position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y + (30f * Time.deltaTime), position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y + (30f * Time.deltaTime), position4.z);
            GameObject.FindGameObjectWithTag("box").transform.position = new Vector3(box.x, box.y + (30f * Time.deltaTime), box.z);

    }
    void jumpDown()
    {
        rotateOldJump1();
        rotateOldJump2();
        GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y - (30f * Time.deltaTime), position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y - (30f * Time.deltaTime), position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y - (30f * Time.deltaTime), position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y - (30f * Time.deltaTime), position4.z);
            GameObject.FindGameObjectWithTag("box").transform.position = new Vector3(box.x, box.y - (30f * Time.deltaTime), box.z);

    }

    void rotateWithJump1()
    {
        if (ball.z > -110.1277f)
        {
            turnBack1 = 1;
            transform.Rotate(Vector3.right, 2);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y + 2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y -2, position2.z);
        }
        else if (ball.z < -110.1277f)
        {
            turnBack1 = 2;
            transform.Rotate(Vector3.left, 2);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y -2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y + 2, position2.z);
        }
    }
    void rotateWithJump2()
    {
        if (ball.x > 25.38906f)
        {
            turnBack2 = 1;
            transform.Rotate(Vector3.down, -2);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y + 2, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y -2 , position4.z);
        }
        else if (ball.x < 25.38906f)
        {
            turnBack2 = 2;
            transform.Rotate(Vector3.up, -2);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y -2, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y +2, position4.z);
        }
    }
    void rotateOldJump1()
    {
        if (turnBack1 == 1)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y - 2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y + 2, position2.z);
        }
        else if (turnBack1 == 2)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y + 2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y - 2, position2.z);
        }
        turnBack1 = 0;
    }
    void rotateOldJump2()
    {
        if (turnBack2 == 1)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y - 2, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y + 2, position4.z);
        }
        else if (turnBack2 == 2)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y + 2, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y - 2, position4.z);
        }
        turnBack2 = 0;
    }
    void rotateArm1()
    {


        if (temp1 > position1.y)
        {
            if (position1.y < 16f)
                position1.y = 16f;

            transform.Rotate(Vector3.right, 3*(temp1 - position1.y));
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x,position2.y + (temp1 - position1.y), position2.z);
        }
        else if (temp1 < position1.y)
        {
            if (position1.y > 22f)
                position1.y = 22f;


            transform.Rotate(Vector3.left, 3 * (position1.y - temp1));
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y - (position1.y - temp1), position2.z);
        }
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;
        temp1 = position1.y;

    }
    void rotateArm3()
    {

        if (temp3 > position3.y)
        {

            if (position3.y < 16f)
                position3.y = 16f;
            transform.Rotate(Vector3.down, 3 * (temp3 - position3.y));
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y + (temp3 - position3.y), position4.z);
        }
        else if (temp3 < position3.y)
        {
            if (position3.y > 22f)
                position3.y = 22f;

            transform.Rotate(Vector3.up, 3 * (position3.y - temp3));
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y - (position3.y - temp3), position4.z);
        }
        position4 = GameObject.FindGameObjectWithTag("upperArm4").transform.position;
        temp3 = position3.y;

    }
}
