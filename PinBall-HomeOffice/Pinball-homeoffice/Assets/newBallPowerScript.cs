using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBallPowerScript : MonoBehaviour
{
    public newBallReadyToShoot newBallReadyToShoot;
    public GameObject ballSpawnPoint;
    public GameObject ballPrefab;
    public float shootNewBallSpeed;
    public bool isFiring;
    public float shootNewBallButtonHoldTimer;
    public float maxPower;

    private void Start()
    {
        shootNewBallButtonHoldTimer = 0f;

        isFiring = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (newBallReadyToShoot.ballIsReadyToShoot == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isFiring = true;
            }

            if (Input.GetButton("Fire1") && isFiring == true)
            {
                if (shootNewBallButtonHoldTimer <= maxPower)
                {
                    shootNewBallButtonHoldTimer = shootNewBallButtonHoldTimer + (Time.deltaTime * 20);
                }
            }

            if (Input.GetButtonUp("Fire1"))
            {
                ShootNewBall();
            }
        }
        
    }

    public void ShootNewBall()
    {
        newBallReadyToShoot.ballIsReadyToShoot = false;
        isFiring = false;
        shootNewBallSpeed = shootNewBallButtonHoldTimer;
        GameObject ballCopy = Instantiate(ballPrefab);
        ballCopy.transform.position = ballSpawnPoint.transform.position;
        Rigidbody2D rigidbody2D = ballCopy.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0f, shootNewBallSpeed);
        shootNewBallButtonHoldTimer = 0f;
    }
}
