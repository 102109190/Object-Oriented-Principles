using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : Gun
{
    // Start is called before the first frame update
    protected override void Start()
    {
        maxAmmoCapacity = 12;
        ammoCount = maxAmmoCapacity;
        base.Start();
    }

    protected override IEnumerator FireGun()
    {
        isFiring = true;

        ammoCount--;

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }
}
