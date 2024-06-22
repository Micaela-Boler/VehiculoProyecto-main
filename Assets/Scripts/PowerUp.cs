using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    [SerializeField] protected GameObject player;

    [SerializeField] public bool activatePowerUp;
    [SerializeField] protected int powerUpDuration;

    [SerializeField] protected MeshRenderer meshRenderer;
    [SerializeField] protected Collider collider;

    [SerializeField] public ParticleSystem particles;
    [SerializeField] AudioSource audio;



    protected void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        activatePowerUp = true;
    }


    protected abstract void apply();


    protected IEnumerator powerUpDurationRoutine()
    {
        activatePowerUp = true;
        apply();

        yield return new WaitForSeconds(powerUpDuration);

        activatePowerUp = false;
        apply();

        Destroy(gameObject);
    }


    protected void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audio.Play();
            particles.Play();

            collider.enabled = false;
            meshRenderer.enabled = false;

            StartCoroutine("powerUpDurationRoutine");
        }
    }
}
