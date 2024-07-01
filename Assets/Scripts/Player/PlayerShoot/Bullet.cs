using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Collider colliderExplosion;
    [SerializeField] MeshRenderer meshRenderer;

    [SerializeField] ParticleSystem particles;
   
    
    private void Start()
    {
        colliderExplosion.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        colliderExplosion.enabled = true;
        meshRenderer.enabled = false;
        particles.Play();

        Destroy(gameObject, 1);
    }
}
