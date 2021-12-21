using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private RoomBounds roomBounds = new RoomBounds(); //Abstraction
    private MainManager _manager;
    
    [SerializeField] private float speed = 5.0f;
    public int hunger { get; private set; } = 100; //Encapsulation
    public int rest { get; private set; } = 100; //Encapsulation
    void Start()
    {
        roomBounds.bottom = -10f;
        roomBounds.top = 10f;
        roomBounds.left = -18.5f;
        roomBounds.right = 18.5f;

        _manager = FindObjectOfType<MainManager>();
        StartCoroutine(TimePass());
    }

    IEnumerator TimePass()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            LowerPlayerNeeds();
            _manager.DisplayPlayerStatus(gameObject);
        }
    }

    void Update()
    {
        Move();
    }

    private void LowerPlayerNeeds() //Abstraction
    {
        hunger--;
        rest--;
        if (hunger < 0)
        {
            hunger = 0;
        }

        if (rest < 0)
        {
            rest = 0;
        }
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
