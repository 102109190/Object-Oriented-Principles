using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : Gun
{
    void Start()
    {
        maxAmmoCapacity = 12;
        ammoCount = maxAmmoCapacity;
    }

    protected override IEnumerator FireGun()
    {
        isFiring = true;

        ammoCount--;

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }
}
