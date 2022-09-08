using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float shotForce = 1500f;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time>shotRateTime && GameManager.instance.gunAmmo>0)
            {
                GameObject newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;
                GameManager.instance.gunAmmo--;
                Destroy(newBullet,1f);
            }
        }
    }

}
