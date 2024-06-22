using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] protected GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }



    void Start()
    {
        float angleRad = Mathf.Atan2(player.transform.position.y - transform.position.x, player.transform.position.x - transform.position.x);
        float angle = (180/Mathf.PI) * angleRad;

        transform.rotation = Quaternion.Euler(0, angle, 0);
    }


    // rota hacia el jugador en el start y luego avanza en linea recta hacia adelante

    //sigue al jugador

}
