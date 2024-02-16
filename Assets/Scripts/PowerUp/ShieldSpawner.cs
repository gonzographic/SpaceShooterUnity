using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] float spawnRate = 2f;
    [SerializeField] GameObject shieldPrefab;

    float yMin;
    float yMax;
    float xSpawn;

    void Start()
    {
        yMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.1f, 0)).y;
        yMax = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.9f, 0)).y;
        xSpawn = Camera.main.ViewportToWorldPoint(new Vector3(1.25f, 0, 1.25f)).x;

        InvokeRepeating("SpawnShield", 0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnShield()
    {
        float randY = Random.Range(yMin, yMax);
        Instantiate(shieldPrefab, new Vector3(xSpawn, randY, xSpawn), Quaternion.Euler(0, 0, 0));
    }
}
