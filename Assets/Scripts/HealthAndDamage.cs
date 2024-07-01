using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthAndDamage : MonoBehaviour
{
    [SerializeField] string collisionTagGameObject;
    [SerializeField] string secondCollisionTagGameObject;
    [SerializeField] string thirdCollisionTagGameObject;

    [SerializeField] public int health;
    [SerializeField] public int damage;

    [SerializeField] public GameObject gameManager;

    [SerializeField] protected ParticleSystem particles;
    [SerializeField] protected AudioSource audio;


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
        if (collision.gameObject.CompareTag(collisionTagGameObject) || collision.gameObject.CompareTag(secondCollisionTagGameObject) || collision.gameObject.CompareTag(secondCollisionTagGameObject))
            TakeDamage();

        if (collision.gameObject.CompareTag("DeadZone"))
            Destroy(gameObject);
    }
    
}
