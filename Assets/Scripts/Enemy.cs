using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] protected GameObject player;

    public CarControl carControl;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.LookAt(player.transform.position);

        carControl.hInput = 1;
        carControl.vInput = 1;
    }


}
