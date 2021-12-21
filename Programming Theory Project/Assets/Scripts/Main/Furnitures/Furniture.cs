using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    [SerializeField] protected Color color;

    void Update()
    {
        SetColor();
    }

    protected virtual void SetColor() // ENCAPSULATION - method not available outside of this class and it's derives.
    {
        var material = gameObject.GetComponent<Renderer>().material;
        material.color = color;
    }
}
