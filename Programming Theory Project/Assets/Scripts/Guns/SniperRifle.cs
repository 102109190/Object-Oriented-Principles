using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRifle : Gun
{
    // Start is called before the first frame update
    void Start()
    {
        maxAmmoCapacity = 6;
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
