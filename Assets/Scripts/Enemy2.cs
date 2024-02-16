using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] GameObject laser;

    [SerializeField] GameManager manager;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, transform.position, Quaternion.Euler(0, 0, 270));
        }

        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.IncreaseScore(10);
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
