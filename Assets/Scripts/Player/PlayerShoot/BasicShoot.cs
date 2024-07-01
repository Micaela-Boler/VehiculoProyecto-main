using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShoot : Shoot
{
    protected override void Attack()
    {
        if (Input.GetMouseButtonDown(0) && activateShoot == true)
            StartCoroutine(BasicShootCooldown());
    }


    protected override void ShootBullet(Vector3 direction, Transform shootPoint, GameObject bulletPrefab, float bulletForce)
    {
        base.ShootBullet(direction, shootPoint, bulletPrefab, bulletForce);

        bulletRB.AddRelativeForce(direction * bulletForce, ForceMode.Impulse);
    }


    IEnumerator BasicShootCooldown()
    {
        ShootBullet(transform.forward, basicShootPoint, bulletPrefab,shootForce);
        activateShoot = false;

        yield return new WaitForSeconds(shootCooldown);

        activateShoot = true;
    }
}
