using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpImmunity : PowerUp
{
    protected override void apply()
    {
        if (activatePowerUp == true)
            player.GetComponent<PlayerHealth>().immunityPowerUp = true;
        else
            player.GetComponent<PlayerHealth>().immunityPowerUp = false;
    }
}
