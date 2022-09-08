using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ammoText;
    public Text healthText;

    public static GameManager instance = null;

    public int gunAmmo = 10;
    public int health = 100;


    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        healthText.text = health.ToString();
    }
}
