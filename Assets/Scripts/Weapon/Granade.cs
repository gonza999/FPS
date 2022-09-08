using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    public float delay = 3f;
    private float countDown;
    public float radius = 5f;
    public float explosionForce = 70f;
    private bool exploded = false;

    public GameObject explosionParticle;
    void Start()
    {
        countDown = delay;
    }

    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown<=0 && !exploded)
        {
            Explode();
            exploded = true;
        }
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position,radius);

        foreach (var rangeObjects in colliders)
        {
            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();
            if (rb!=null)
            {
                rb.AddExplosionForce(explosionForce*10,transform.position,radius);
            }
        }
        Instantiate(explosionParticle,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
