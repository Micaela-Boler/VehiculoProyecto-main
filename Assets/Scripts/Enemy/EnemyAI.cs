using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : EnemyMovement
{
    [Header("ENEMY STATE")]
    public EnemyState enemyState;
    public enum EnemyState
    {
        Chasing,
        Escaping
    }

    

    private void Start()
    {
        enemyState = EnemyState.Chasing;
    }



    private void Update()
    {
        switch (enemyState)
        {   
            case EnemyState.Chasing:
                {
                    EnemyRotation();
                    EnemyCarControl(1, 1);
                }
                break;

            case EnemyState.Escaping:
                {
                    EnemyRotation();
                    EnemyCarControl(-1,-1);
                }
                break;
        }


        if (gameObject.GetComponent<EnemyHealth>().health <= 1)
            enemyState = EnemyState.Escaping;
    }

}
