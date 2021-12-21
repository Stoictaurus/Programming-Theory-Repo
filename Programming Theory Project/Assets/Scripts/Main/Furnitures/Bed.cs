using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Furniture
{
    protected override void SetColor()  //POLYMORPHISM
    {
        base.SetColor();
        var children = GetComponentsInChildren<Transform>();
        foreach (var child in children) 
        {
            var material = child.gameObject.GetComponent<Renderer>().material;
            material.color = color;
        }
    }
}
