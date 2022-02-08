using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Gun : MonoBehaviour //ABSTRACTION
{
    public Text ammoCountDisplay;

    protected int maxAmmoCapacity;
    protected int ammoCount;

    public float fireRate;

    protected bool isFiring = false;

    protected void Update()
    {
        ammoCountDisplay.text = ammoCount.ToString();

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ammoCount != maxAmmoCapacity)
            {
                ReloadGun();
            }
        }

        if (Input.GetButton("Fire1") && !isFiring)
        {
            if (ammoCount > 0)
                StartCoroutine(FireGun());
            else
                ReloadGun();
        }
    }
    protected virtual IEnumerator FireGun() {yield return new WaitForSeconds(0);}
    protected virtual void ReloadGun() { ammoCount = maxAmmoCapacity; }
}
