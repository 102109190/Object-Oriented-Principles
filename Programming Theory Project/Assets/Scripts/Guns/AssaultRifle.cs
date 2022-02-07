using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Gun
{
    // Start is called before the first frame update
    void Start()
    {
        maxAmmoCapacity = 30;
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
