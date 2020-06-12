using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperScript : MonoBehaviour
{

    public HingeJoint2D leftFlipperHingeJoint;
    public HingeJoint2D rightFlipperHingeJoint;

    public bool leftFlipperMotorOn;
    public bool rightFlipperMotorOn;

        // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("LeftFlipper"))
        {
            leftFlipperHingeJoint.useMotor = true;
            leftFlipperMotorOn = true;
        }
        else
        {
            leftFlipperHingeJoint.useMotor = false;
            leftFlipperMotorOn = false;
        }

        if (Input.GetButton("RightFlipper"))
        {
            rightFlipperHingeJoint.useMotor = true;
            rightFlipperMotorOn = true;
        }
        else
        {
            rightFlipperHingeJoint.useMotor = false;
            rightFlipperMotorOn = false;
        }
    }
}
