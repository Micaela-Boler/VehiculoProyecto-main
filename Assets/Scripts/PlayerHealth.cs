using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthAndDamage
{
    public bool immunityPowerUp;

    [SerializeField] protected Animator animator;



    private void Start()
    {
        immunityPowerUp = false;
    }


    protected override void TakeDamage()
    {
        if (immunityPowerUp != true) 
        {
            base.TakeDamage();


            if (health == health / 3)
            {
                animator.SetTrigger("LowHealth");
                particles.Play();

                if (health <= 0)
                    gameObject.GetComponent<GameManager>().ChangeScene(1);
            }
        }
    }
}
