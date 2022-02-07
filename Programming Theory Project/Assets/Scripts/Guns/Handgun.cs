using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : Gun //INHERITANCE
{
    void Start()
    {
        maxAmmoCapacity = 12;
        ammoCount = maxAmmoCapacity;
    }

    protected override IEnumerator FireGun() //POLYMORPHISM
    {
        isFiring = true;

        ammoCount--;

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }
}
