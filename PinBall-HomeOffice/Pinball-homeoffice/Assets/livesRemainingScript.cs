using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesRemainingScript : MonoBehaviour
{
    public Text livesRemainingText;
    public float startingLives;
    public float remainingLives;

    private void Start()
    {
        remainingLives = startingLives;
    }

    private void Update()
    {
        livesRemainingText.text = remainingLives.ToString();
    }
}
