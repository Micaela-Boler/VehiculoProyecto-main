using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoot : MonoBehaviour
{
    [SerializeField] protected float timeToDestroyBullet;
    protected Rigidbody bulletRB;


    [Header("PREFAB")]
    [SerializeField] protected GameObject bulletPrefab;

    [Header("TRANSFORM")]
    [SerializeField] protected Transform basicShootPoint;
    [SerializeField] protected List<Transform> shootPointsList = new List<Transform>();

    [Header("FORCE")]
    [SerializeField] protected float shootForce;

    [Header("ACTIVATE SHOOT")]
    protected bool activateShoot;

    [Header("COOLDOWN")]
    [SerializeField] protected float shootCooldown;

    [Header("AUDIO")]
    [SerializeField] protected AudioSource audio;



    private void Start()
    {
        activateShoot = true;
    }

    void Update()
    {
        Attack();
    }


    protected abstract void Attack();


    protected virtual void ShootBullet(Vector3 direction, Transform shootPoint, GameObject bulletPrefab, float bulletForce)
    {
        GameObject bulletClon = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        bulletRB = bulletClon.GetComponent<Rigidbody>();

        audio.Play();
        Destroy(bulletClon, timeToDestroyBullet);
    }
}
