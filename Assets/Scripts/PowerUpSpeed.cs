using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUp
{
    [SerializeField] private float valorAgregado;


    protected override void apply()
    {
        if (activatePowerUp == true)
            player.GetComponent<CarControl>().motorTorque += valorAgregado;
        else
            player.GetComponent<CarControl>().motorTorque -= valorAgregado;
    }
}
