using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI :CarControl
{
    [Header("jugador")]
    [SerializeField] GameObject player;

    public enum EnemyState
    {
        Chasing,
        Escaping
    }

    public EnemyState enemyState;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }



    private void Update()
    {
        if (player != null) 
        {
            /*
            if (gameObject.GetComponent<EnemyHealth>().health > 1)
            {
                enemyState = EnemyState.Chasing;
            }
            */

            /*
            switch (enemyState)
            {
                case EnemyState.Chasing:
            }
            */


            if (enemyState == EnemyState.Chasing)
            {
                
                
                // desde el principio sigue al jugador
            }

            if (enemyState == EnemyState.Escaping)
            {


                //si la vida es baja huye
            }

        }




    }

}
