using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public WeaponInventory weapInv;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchWeapon(2);
        }
    }

    private void SwitchWeapon(int weaponSlot)
    {
        for (int i = 0; i < weapInv.Weapons.Count; i++)
        {
            if (i == weaponSlot)
            {
                weapInv.Weapons[i].SetActive(true);
            }
            else
            {
                weapInv.Weapons[i].SetActive(false);
            }
        }
    }
}
