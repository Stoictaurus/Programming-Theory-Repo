using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Furniture
{
    protected override void SetColor()  //POLYMORPHISM - Change how method works - apply also to children
    {
        base.SetColor();
        var children = GetComponentsInChildren<Transform>();
        foreach (var child in children) 
        {
            var material = child.gameObject.GetComponent<Renderer>().material;
            material.color = color;
        }
    }

    private void OnTriggerEnter(Collider other) // Plymorphism - Resting - Unique Bed Feature
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<Player>();
            player.FixRest();
        }
    }
}
