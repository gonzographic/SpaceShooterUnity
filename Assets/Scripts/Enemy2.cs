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

      

        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiateGameOver();
        }
        else
        {
            GameManager.instance.IncreaseScore(10);
        }

        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
