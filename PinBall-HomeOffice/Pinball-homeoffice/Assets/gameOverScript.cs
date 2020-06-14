using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverScript : MonoBehaviour
{
    public GameObject gameOverPanel;
    public livesRemainingScript livesRemainingScript;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (livesRemainingScript.remainingLives == 0f)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

}
