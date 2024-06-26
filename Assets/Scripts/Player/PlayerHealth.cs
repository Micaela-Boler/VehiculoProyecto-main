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
            audio.Play();


            if (health <= 2)
            {
                animator.SetTrigger("LowHealth");

                if (health <= 0)
                    Destroy(gameObject);
            }
        }
    }
}
