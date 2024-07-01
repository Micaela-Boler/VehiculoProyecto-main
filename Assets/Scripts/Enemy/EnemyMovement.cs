using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("PLAYER")]
    protected GameObject player;

    [Header("CAR CONTROL SCRIPT")]
    public CarControl carControl;



    protected void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void Start()
    {
        EnemyRotation();
    }

    private void Update()
    {
        EnemyCarControl(1, 0);
    }


    protected void EnemyRotation()
    {
        if (player != null)
            transform.LookAt(player.transform.position);
    }

    protected void EnemyCarControl(int vInputValue, int hInputValue)
    {
        carControl.hInput = hInputValue;
        carControl.vInput = vInputValue;
    }


}
