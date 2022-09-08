using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("GunAmmo"))
        {
            GameManager.instance.gunAmmo += c.gameObject.GetComponent<AmmoBox>().ammo;
            Destroy(c.gameObject);
        }
    }
}
