using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> weapons = new List<GameObject>();

    public List<GameObject> Weapons //ENCAPSULATION
    {
        get
        {
            return weapons;
        }
    }
}
