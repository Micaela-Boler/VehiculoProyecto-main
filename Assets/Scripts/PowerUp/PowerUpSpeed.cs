using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDoubleShoot : PowerUp
{
    protected override void apply()
    {
        if (activatePowerUp == true)
            player.GetComponent<DoubleShoot>().shootPowerUp = true;
        else
            player.GetComponent<DoubleShoot>().shootPowerUp = false;
    }
}
