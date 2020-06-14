using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostBallScript : MonoBehaviour
{

    public livesRemainingScript livesRemainingScript;
    public newBallReadyToShoot newBallReadyToShoot;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            livesRemainingScript.remainingLives--;
            newBallReadyToShoot.ballIsReadyToShoot = true;
        }
    }
}
