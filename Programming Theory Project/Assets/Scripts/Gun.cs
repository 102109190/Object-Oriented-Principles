using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Gun : MonoBehaviour
{
    public Text ammoCountDisplay;

    public int maxAmmoCapacity;
    public int ammoCount;

    public float fireRate;

    protected bool isFiring = false;

    protected virtual void Start()
    {
        ammoCountDisplay.text = ammoCount.ToString();
    }

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

        if (Input.GetButtonDown("Fire1") && !isFiring)
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
