using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRifle : Gun //INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        maxAmmoCapacity = 6;
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
