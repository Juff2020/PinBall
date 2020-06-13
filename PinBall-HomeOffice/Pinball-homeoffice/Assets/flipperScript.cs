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


    public bool leftFlipperMotorOn;
    public bool rightFlipperMotorOn;


    private void Start()
    {
        leftMotor2D = leftFlipperHingeJoint.motor;
        leftMotor2D.motorSpeed = leftFlipperMotorSpeed;

        rightMotor2D = rightFlipperHingeJoint.motor;
        rightMotor2D.motorSpeed = rightFlipperMotorSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Left Flipper"))
        {
            leftFlipperHingeJoint.useMotor = true;
            leftFlipperMotorOn = true;
        }
        else
        {
            leftFlipperHingeJoint.useMotor = false;
            leftFlipperMotorOn = false;
        }

        if (Input.GetButton("Right Flipper"))
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
