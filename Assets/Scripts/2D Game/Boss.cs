using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public TMP_Text winText;
    public Enemy enemy;


    private void Start()
    {
        winText.enabled = false;
    }

    private void Update()
    {
        int health = enemy.health;

        if (health <= 0)
        {
            winText.enabled = true;
        }
    }

}
