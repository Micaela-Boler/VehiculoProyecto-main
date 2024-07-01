using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    [SerializeField] protected ParticleSystem playersParticleSystem;

    [SerializeField] public bool activatePowerUp = true;
    [SerializeField] protected int powerUpDuration;

    [SerializeField] protected MeshRenderer meshRenderer;
    [SerializeField] protected Collider collider;

    [SerializeField] public ParticleSystem particles;
    [SerializeField] AudioSource audio;



    protected void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        playersParticleSystem = player.GetComponent<ParticleSystem>();
    }


    protected abstract void apply();


    protected IEnumerator powerUpDurationRoutine()
    {
        playersParticleSystem.Play();
        activatePowerUp = true;
        apply();

        yield return new WaitForSeconds(powerUpDuration);

        playersParticleSystem.Stop();
        activatePowerUp = false;
        apply();

        Destroy(gameObject);
    }


    protected void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audio.Play();

            collider.enabled = false;
            meshRenderer.enabled = false;

            StartCoroutine("powerUpDurationRoutine");
        }
    }
}
