using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] GameObject laser;
    [SerializeField] GameObject laser2;

    private Rigidbody2D _rigidbody;

    float horizontal;
    float vertical;
    

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, transform.position, Quaternion.Euler(0, 0, 270));
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(laser2, transform.position, Quaternion.Euler(0, 0, 270));
        }

    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(horizontal * _speed, vertical * _speed);
    }
}
