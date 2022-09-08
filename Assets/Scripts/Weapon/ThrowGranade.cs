using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGranade : MonoBehaviour
{
    public GameObject granadePrefab;
    public float throwForce=500;

    private void Update()
    {
        Throw();
    }
    private void Throw()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throwing();
        }
    }
    private void Throwing()
    {
        GameObject newGranade= Instantiate(granadePrefab,transform.position,transform.rotation);
        newGranade.GetComponent<Rigidbody>().AddForce(transform.forward*throwForce);
    }
}
