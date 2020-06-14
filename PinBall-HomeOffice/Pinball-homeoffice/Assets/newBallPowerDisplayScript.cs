using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newBallPowerDisplayScript : MonoBehaviour
{
    public Slider slider;
    public newBallPowerScript newBallPowerScript;

    private void Update()
    {
        slider.maxValue = newBallPowerScript.maxPower;
        slider.value = newBallPowerScript.shootNewBallButtonHoldTimer;
    }
}
