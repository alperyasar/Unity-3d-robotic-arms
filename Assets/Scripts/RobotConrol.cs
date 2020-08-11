using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotConrol : MonoBehaviour
{
    public float robotBaseSliderValue = 0.0F;
    public float robotUpperSliderValue = 0.0F;
    public float robotLowerSliderValue = 0.0F;

    public Transform RobotBase;
    public Transform RobotUpperArm;
    public Transform RobotLowerArm;

    public float baseTurnRate = 5;
    public float upperArmTurnRate = 5;
    public float lowerArmTurnRate = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RobotBase.Rotate(0, robotBaseSliderValue * baseTurnRate, 0);
        RobotUpperArm.Rotate(robotUpperSliderValue * baseTurnRate, 0, 0);
        RobotLowerArm.Rotate(robotLowerSliderValue * baseTurnRate, 0, 0);
        if (Input.GetMouseButtonUp(0))
        {
            robotBaseSliderValue = 0;
            robotUpperSliderValue = 0;
            robotLowerSliderValue = 0;
        }
    }
    void onGUI()
    {
        robotBaseSliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), robotBaseSliderValue, -10.0F, 10.0F);
        robotUpperSliderValue = GUI.HorizontalSlider(new Rect(25, 60, 100, 30), robotUpperSliderValue, -10.0F, 10.0F);
        robotLowerSliderValue = GUI.HorizontalSlider(new Rect(25, 60, 100, 30), robotLowerSliderValue, -10.0F, 10.0F);
    }
}
