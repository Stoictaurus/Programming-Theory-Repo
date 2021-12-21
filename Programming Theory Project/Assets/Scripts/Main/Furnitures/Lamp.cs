using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : Furniture
{
    protected override void SetColor() // Polymorphism - Change how SetColor works - change color of lite insted of object.
    {
        gameObject.GetComponent<Light>().color = color;
    }
}
