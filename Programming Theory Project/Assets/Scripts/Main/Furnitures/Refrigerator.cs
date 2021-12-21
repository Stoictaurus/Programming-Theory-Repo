using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refrigerator : Furniture 
{
    private void OnTriggerEnter(Collider other) //Polymorphism - Feeding - unique Refrigerator feature
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<Player>();
            player.FixHunger();
        }
    }
}
