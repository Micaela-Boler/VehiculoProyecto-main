using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShoot : Shoot
{
    public bool shootPowerUp;


    protected override void Attack()
    {
        if (Input.GetMouseButtonDown(1) && activateShoot && shootPowerUp)
            StartCoroutine(BasicShootCooldown());
    }


    protected override void ShootBullet(Vector3 direction, Transform shootPoint, GameObject bulletPrefab, float bulletForce)
    {
        base.ShootBullet(direction, shootPoint, bulletPrefab, bulletForce);

        bulletRB.AddRelativeForce(direction * bulletForce, ForceMode.Impulse);
        bulletRB.AddRelativeForce(transform.up * bulletForce / 4, ForceMode.Impulse);
    }


    IEnumerator BasicShootCooldown()
    {
        for (int i = 0; i < shootPointsList.Count; i++)
        {
            ShootBullet(transform.forward, shootPointsList[i], bulletPrefab, shootForce);
        }

        activateShoot = false;

        yield return new WaitForSeconds(shootCooldown);

        activateShoot = true;
    }
}

