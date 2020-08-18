using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfBox : MonoBehaviour
{
    //  public Transform upperArm1;
    // Start is called before the first frame update
    public int purpose = 2;
    public float xAxis, zAxis;
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
        ball = GameObject.FindGameObjectWithTag("ball").transform.position;
        xAxis = ball.x;
        zAxis = ball.z;
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

            if (ball.x == xAxis && ball.z == zAxis)
            {
                rotateOldPurpose21();
                rotateOldPurpose22();
            }
            else if (ball.x > xAxis && ball.z > zAxis)
            {
                transform.localRotation = Quaternion.Euler(-95, 35, 145);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 17.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 21.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 21.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 17.37371f, position4.z);
            }
            else if (ball.x < xAxis && ball.z > zAxis)
            {
                transform.localRotation = Quaternion.Euler(-84, 138, 40);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 17.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 21.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 17.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 21.37371f, position4.z);
            }
            else if (ball.x > xAxis && ball.z < zAxis)
            {
                transform.localRotation = Quaternion.Euler(-96, 135, 44);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 21.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 17.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 21.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 17.37371f, position4.z);
            }
            else if (ball.x < xAxis && ball.z < zAxis)
            {
                transform.localRotation = Quaternion.Euler(-96, 245, -68);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 21.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 17.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 17.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 21.37371f, position4.z);
            }
            else if (ball.x > xAxis )
            {
                transform.localRotation = Quaternion.Euler(-95, 90, 90);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 21.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 17.37371f, position4.z);
            }
            else if (ball.x < xAxis)
            {
                transform.localRotation = Quaternion.Euler(-85, 90, 90);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 29.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 17.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 21.37371f, position4.z);
            }
            else if (ball.z < zAxis)
            {
                transform.localRotation = Quaternion.Euler(-95, 180, 0);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 21.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 17.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
            }
            else if (ball.z > zAxis)
            {
                transform.localRotation = Quaternion.Euler(-85, 180, 0);
                GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 17.37371f, position1.z);
                GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 21.37371f, position2.z);
                GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
                GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
            }
            /*
            if ((int)ball.x != (int)xAxis)
            {
                transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, 0, 180);
                rotateWithJumpPurpose22();
            }
            if ((int)ball.z != (int)zAxis)
            {
                transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, 90, 90);
                rotateWithJumpPurpose21();

            }
            if((int)ball.x == (int)xAxis && (int)ball.z == (int)zAxis)
            {
                rotateOldPurpose21();
                rotateOldPurpose22();
            }
            if (transform.eulerAngles.x > 280)
                transform.localEulerAngles = new Vector3(280, transform.eulerAngles.y, transform.eulerAngles.z);
            else if (transform.eulerAngles.x < 260)
                transform.localEulerAngles = new Vector3(260, transform.eulerAngles.y, transform.eulerAngles.z);*/

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
            transform.Rotate(Vector3.right, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y + 2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y -2, position2.z);
        }
        else if (ball.z < -110.1277f)
        {
            turnBack1 = 2;
            transform.Rotate(Vector3.left, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y -2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y + 2, position2.z);
        }
    }
    void rotateWithJump2()
    {
        if (ball.x > 25.38906f)
        {
            turnBack2 = 1;
            transform.Rotate(Vector3.down, -80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y + 2, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y -2 , position4.z);
        }
        else if (ball.x < 25.38906f)
        {
            turnBack2 = 2;
            transform.Rotate(Vector3.up, -80 * Time.deltaTime);
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

    void rotateWithJumpPurpose21()
    {
        if (ball.z > zAxis)
        {
            turnBack1 = 1;
               transform.Rotate(Vector3.left, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f + 80 * Time.deltaTime, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f - 80 * Time.deltaTime, position2.z);
            /*   if(ball.z > zAxis + 5)
               {
                   Debug.Log(ball.z + " sikik1 " + zAxis);

                   transform.localRotation = Quaternion.Euler(100, 0, 180);
                   GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f + (float)(Math.Cos(10) * 10) , position1.z);
                   GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f - (float)(Math.Cos(10) * 10), position2.z);

               }
               else
               {
                   Debug.Log(ball.z + " sikik2 " + zAxis);
                   transform.localRotation = Quaternion.Euler(90 + ((ball.z-zAxis) * 2), 0, 180);
                   GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f + (float)(Math.Cos(10) * ((ball.z - zAxis) * 2)), position1.z);
                   GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f - (float)(Math.Cos(10) * ((ball.z - zAxis) * 2)), position2.z);

               }*/

        }
        else if (ball.z < zAxis)
        {
            turnBack1 = 2;
                transform.Rotate(Vector3.right, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f - 80 * Time.deltaTime, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f + 80 * Time.deltaTime, position2.z);
            /*  if (ball.z < zAxis - 5)
              {
                  transform.localRotation = Quaternion.Euler(80, 0, 180);
                  GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f - (float)(Math.Cos(10) * 10), position1.z);
                  GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f + (float)(Math.Cos(10) * 10), position2.z);

              }
              else
              {
                  transform.localRotation = Quaternion.Euler(90 - ((zAxis - ball.z) * 2), 0, 180);
                  GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f - (float)(Math.Cos(10) * ((zAxis - ball.z) * 2)), position1.z);
                  GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f + (float)(Math.Cos(10) * ((zAxis - ball.z) * 2)), position2.z);

              }*/
        }
    }
    void rotateWithJumpPurpose22()
    {
        if (ball.x > xAxis)
        {
            turnBack2 = 1;

           transform.Rotate(Vector3.up, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f - 80 * Time.deltaTime, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f + 80 * Time.deltaTime, position4.z);
            //    transform.Rotate(80 * Time.deltaTime, 90, 90);
            /*   if (ball.x > xAxis + 5)
               {
                   transform.localRotation = Quaternion.Euler(-100, 90, 90);
                   GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f - (float)(Math.Cos(10) * 10), position3.z);
                   GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f + (float)(Math.Cos(10) * 10), position4.z);

               }
               else
               {
                   transform.localRotation = Quaternion.Euler(-90 - ((ball.x - xAxis) * 2), 90, 90);
                   GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f - (float)(Math.Cos(10) * ((ball.x - xAxis) * 2)), position3.z);
                   GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f + (float)(Math.Cos(10) * ((ball.x - xAxis) * 2)), position4.z);

               }*/
        }
        else if (ball.x < xAxis)
        {
            turnBack2 = 2;
               transform.Rotate(Vector3.down, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f + 80*Time.deltaTime, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f - 80 * Time.deltaTime, position4.z);
            /*   //    transform.Rotate(80 * Time.deltaTime, 90, 90);
               if (ball.z < zAxis - 5)
               {
                   transform.localRotation = Quaternion.Euler(-80, 90, 90);
                   GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f + (float)(Math.Cos(10) * 10), position3.z);
                   GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f - (float)(Math.Cos(10) * 10), position4.z);

               }
               else
               {
                   transform.localRotation = Quaternion.Euler(-90 + ((xAxis - ball.x) * 2), 90, 90);
                   GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f + (float)(Math.Cos(10) * ((xAxis - ball.x) * 2)), position3.z);
                   GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f - (float)(Math.Cos(10) * ((xAxis - ball.x) * 2)), position4.z);

               }*/
        }
    }
    void rotateOldPurpose21()
    {
        if (turnBack1 == 1)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f, position2.z);
        }
        else if (turnBack1 == 2)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f, position2.z);
        }
        turnBack1 = 0;
    }
    void rotateOldPurpose22()
    {
        if (turnBack2 == 1)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
        }
        else if (turnBack2 == 2)
        {
            transform.localEulerAngles = new Vector3(-90, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
        }
        turnBack2 = 0;
    }
}
