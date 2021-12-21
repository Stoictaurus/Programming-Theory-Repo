using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private RoomBounds roomBounds = new RoomBounds(); //Abstraction
    [SerializeField] private float speed = 5.0f;
    void Start()
    {
        roomBounds.bottom = -10f;
        roomBounds.top = 10f;
        roomBounds.left = -18.5f;
        roomBounds.right = 18.5f;
    }


    void Update()
    {
        Move();
    }

    private void Move() //Abstraction
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var relocationX = Vector3.right * Time.deltaTime * horizontal * speed;
        var relocationZ = Vector3.forward * Time.deltaTime * vertical * speed;
        if (horizontal != 0 && roomBounds.PointInBounds( transform.position + relocationX ))
        {
            transform.Translate(relocationX);
        }

        if (vertical != 0 && roomBounds.PointInBounds(transform.position + relocationZ))
        {
            transform.Translate(relocationZ);
        }
    }
}
