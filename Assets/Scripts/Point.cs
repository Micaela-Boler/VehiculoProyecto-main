using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public static event Action<int> point;

    [SerializeField] int pointValue;

    [SerializeField] AudioSource audio;
    [SerializeField] ParticleSystem particles;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            point?.Invoke(pointValue);

            audio.Play();
            particles.Play();
            Destroy(gameObject, 0.3f);
        }
    }
}
