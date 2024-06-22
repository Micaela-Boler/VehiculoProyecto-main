using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthAndDamage : MonoBehaviour
{
    [SerializeField] string collisionTagGameObject;
    [SerializeField] string secondCollisionTagGameObject;

    [SerializeField] protected int health;
    [SerializeField] public int damage;

    [SerializeField] GameObject gameManager;

    [SerializeField] protected ParticleSystem particles;
    [SerializeField] protected AudioSource audio;

    //get set con el daño


    protected void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    protected virtual void TakeDamage()
    {
        health -= damage;
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(collisionTagGameObject) || collision.gameObject.CompareTag(secondCollisionTagGameObject))
            TakeDamage();
    }
    
}
