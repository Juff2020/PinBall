using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperScript : MonoBehaviour
{
    public HingeJoint2D leftFlipperHingeJoint;
    private JointMotor2D leftMotor2D;
    public Rigidbody2D leftFlipperRigidBody2D;
    public float leftFlipperMass;
    public float leftFlipperMotorSpeed;

    public HingeJoint2D rightFlipperHingeJoint;
    private JointMotor2D rightMotor2D;
    public Rigidbody2D rightFlipperRigidBody2D;
    public float rightFlipperMass;
    public float rightFlipperMotorSpeed;

    public HingeJoint2D highRightFlipperHingeJoint;
    private JointMotor2D highRightMotor2D;
    public Rigidbody2D highRightFlipperRigidBody2D;
    public float highRightFlipperMass;
    public float highRightFlipperMotorSpeed;

    private void Start()
    {
        leftMotor2D = leftFlipperHingeJoint.motor;
        leftMotor2D.motorSpeed = leftFlipperMotorSpeed;

        rightMotor2D = rightFlipperHingeJoint.motor;
        rightMotor2D.motorSpeed = rightFlipperMotorSpeed;

        highRightMotor2D = highRightFlipperHingeJoint.motor;
        highRightMotor2D.motorSpeed = highRightFlipperMotorSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Left Flipper"))
        {
            leftFlipperHingeJoint.useMotor = true;
        }
        else
        {
            leftFlipperHingeJoint.useMotor = false;
        }

        if (Input.GetButton("Right Flipper"))
        {
            rightFlipperHingeJoint.useMotor = true;

            highRightFlipperHingeJoint.useMotor = true;
        }
        else
        {
            rightFlipperHingeJoint.useMotor = false;
            highRightFlipperHingeJoint.useMotor = false;
        }
    }
}
