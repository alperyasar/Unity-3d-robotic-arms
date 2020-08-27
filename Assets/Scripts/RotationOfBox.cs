using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RotationOfBox : MonoBehaviour
{
    //  public Transform upperArm1;
    // Start is called before the first frame update
    public int purpose = 2;
    public float xAxis, zAxis;
    int upDown = 1;
    int turnBack1, turnBack2;
    float tempX, tempZ, tempY ,speed;
    Vector3 position1, position2, position3, position4;
    Vector3 ball, box;
    void Start()
    {
        position1 = GameObject.FindGameObjectWithTag("upperArm1").transform.position;
        position2 = GameObject.FindGameObjectWithTag("upperArm2").transform.position;
        position3 = GameObject.FindGameObjectWithTag("upperArm3").transform.position;
        ball = GameObject.FindGameObjectWithTag("ball").transform.position;
        xAxis = tempX = ball.x;
        tempY = ball.y;
        zAxis = tempZ = ball.z;
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
            if ((int)ball.x == (int)xAxis && (int)ball.z == (int)zAxis)
                rotateOldPurpose();
            else if ((int)ball.x > (int)xAxis && (int)ball.z > (int)zAxis)
                purpose1();
            else if ((int)ball.x < (int)xAxis && (int)ball.z > (int)zAxis)
                purpose2();
            else if ((int)ball.x > (int)xAxis && (int)ball.z < (int)zAxis)
                purpose3();
            else if ((int)ball.x < (int)xAxis && (int)ball.z < (int)zAxis)
                purpose4();
            else if ((int)ball.x > (int)xAxis )
                purpose5();
            else if ((int)ball.x < (int)xAxis)
                purpose6();
            else if ((int)ball.z < (int)zAxis)
                purpose7();
            else if ((int)ball.z > (int)zAxis)
                purpose8();
            
            tempX = ball.x;
            tempY = ball.y;
            tempZ = ball.y;
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
        if (ball.z > 0f)
        {
            turnBack1 = 1;
            transform.Rotate(Vector3.right, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y + 2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y -2, position2.z);
        }
        else if (ball.z < 0f)
        {
            turnBack1 = 2;
            transform.Rotate(Vector3.left, 80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, position1.y -2, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, position2.y + 2, position2.z);
        }
    }
    void rotateWithJump2()
    {
        if (ball.x > 0f)
        {
            turnBack2 = 1;
            transform.Rotate(Vector3.down, -80 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, position3.y + 2, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, position4.y -2 , position4.z);
        }
        else if (ball.x < 0f)
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
    void rotateOldPurpose()
    {
        transform.localEulerAngles = new Vector3(-90, 90, 90);
        GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
        GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f, position2.z);
        GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
        GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
    }
    void purpose1()
    {
        speed = (float)Math.Sqrt((float)Math.Pow((ball.x-tempX) / Time.deltaTime, 2) + (float)Math.Pow((ball.z - tempZ) / Time.deltaTime, 2));
        if (ball.x > xAxis && ball.z > zAxis)
        {
            transform.localRotation = Quaternion.Euler(-95, 35, 145);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 17.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 21.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 21.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 17.37371f, position4.z);
        }
        else if (ball.x < xAxis && ball.z < zAxis && speed > 0.8)
            purpose4();
        else if (ball.x > xAxis && ball.z < zAxis && speed > 0.8)
            purpose3();
        else if (ball.x < xAxis && ball.z > zAxis && speed > 0.8)
            purpose2();
        else rotateOldPurpose();
    }
    void purpose2()
    {
        speed = (float)Math.Sqrt((float)Math.Pow((ball.x - tempX) / Time.deltaTime, 2) + (float)Math.Pow((ball.z - tempZ) / Time.deltaTime, 2));
        if (ball.x < xAxis && ball.z > zAxis)
        {
            transform.localRotation = Quaternion.Euler(-84, 138, 40);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 17.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 21.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 17.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 21.37371f, position4.z);
        }
        else if (ball.x < xAxis && ball.z < zAxis && speed > 0.8)
            purpose4();
        else if (ball.x > xAxis && ball.z < zAxis && speed > 0.8)
            purpose3();
        else if (ball.x > xAxis && ball.z > zAxis && speed > 0.8)
            purpose1();
        else rotateOldPurpose();
        
    }
    void purpose3()
    {
        speed = (float)Math.Sqrt((float)Math.Pow((ball.x - tempX) / Time.deltaTime, 2) + (float)Math.Pow((ball.z - tempZ) / Time.deltaTime, 2));
        if (ball.x > xAxis && ball.z < zAxis)
        {
            transform.localRotation = Quaternion.Euler(-96, 135, 44);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 21.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 17.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 21.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 17.37371f, position4.z);
        }
        else if (ball.x < xAxis && ball.z < zAxis && speed > 0.8)
            purpose4();
        else if (ball.x < xAxis && ball.z > zAxis && speed > 0.8)
            purpose2();
        else if (ball.x > xAxis && ball.z > zAxis && speed > 0.8)
            purpose1();
        else rotateOldPurpose();
        
    }
    void purpose4()
    {
        speed = (float)Math.Sqrt((float)Math.Pow((ball.x - tempX) / Time.deltaTime, 2) + (float)Math.Pow((ball.z - tempZ) / Time.deltaTime, 2));
        if (ball.x < xAxis && ball.z < zAxis)
        {
            transform.localRotation = Quaternion.Euler(-96, 245, -68);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 21.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 17.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 17.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 21.37371f, position4.z);
        }
        else if (ball.x > xAxis && ball.z < zAxis && speed > 0.8)
            purpose3();
        else if (ball.x < xAxis && ball.z > zAxis && speed > 0.8)
            purpose2();
        else if (ball.x > xAxis && ball.z > zAxis && speed > 0.8)
            purpose1();
        else rotateOldPurpose();
        
    }
    void purpose5()
    {
        speed = (ball.x - tempX) / Time.deltaTime;
        Debug.Log(speed);
        if (ball.x > xAxis && speed > -0.8)
        {
            transform.localRotation = Quaternion.Euler(-95, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 21.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 17.37371f, position4.z);
        }
        else if (speed < -0.8f)
            purpose6();
        else
            rotateOldPurpose();
        
    }
    void purpose6()
    {
        
        speed = (ball.x - tempX) / Time.deltaTime;
        Debug.Log(speed);
        if (ball.x < xAxis && speed < 0.8)
        {
            transform.localRotation = Quaternion.Euler(-85, 90, 90);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 19.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 19.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 17.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 21.37371f, position4.z);
        }
        else if (speed > 0.8f)
            purpose5();
        else
            rotateOldPurpose();
        
    }
    void purpose7()
    {
        speed = (ball.z - tempZ) / Time.deltaTime;
        Debug.Log(speed);
        if (ball.z < zAxis && speed < 0.8)
        {
            transform.localRotation = Quaternion.Euler(-95, 180, 0);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 21.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 17.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
        }
        else if (speed > 0.8f)
            purpose8();
        else
            rotateOldPurpose();
        
    }
    void purpose8()
    {
        speed = (ball.z - tempZ) / Time.deltaTime;
        Debug.Log(speed);
        if (ball.z > zAxis && speed > -0.8)
        {
            transform.localRotation = Quaternion.Euler(-85, 180, 0);
            GameObject.FindGameObjectWithTag("upperArm1").transform.position = new Vector3(position1.x, 17.37371f, position1.z);
            GameObject.FindGameObjectWithTag("upperArm2").transform.position = new Vector3(position2.x, 21.37371f, position2.z);
            GameObject.FindGameObjectWithTag("upperArm3").transform.position = new Vector3(position3.x, 19.37371f, position3.z);
            GameObject.FindGameObjectWithTag("upperArm4").transform.position = new Vector3(position4.x, 19.37371f, position4.z);
        }
        else if (speed < -0.8f)
            purpose7();
        else
            rotateOldPurpose();
        
    }
}
