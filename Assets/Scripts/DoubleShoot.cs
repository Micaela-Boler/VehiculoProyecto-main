using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShoot : Shoot
{

    protected override void Attack()
    {
        if (Input.GetMouseButtonDown(1) && activateShoot == true)
            StartCoroutine(DoubleShootCooldown());
    }
    
    
    protected override void ShootBullet(Vector3 direction, Transform shootPoint, GameObject bulletPrefab, float bulletForce)
    {
        base.ShootBullet(transform.forward, shootPoint, bulletPrefab, shootForce);


        bulletRB.AddRelativeForce(direction * bulletForce, ForceMode.Impulse);
        //bulletRB.AddRelativeForce(direction * bulletForce / 3, ForceMode.Impulse);



        bulletRB.AddForce(transform.up * shootForce / 4/*, ForceMode.Impulse*/);

        bulletRB.AddForce(transform.forward * shootForce);
    }


    protected IEnumerator DoubleShootCooldown()
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

