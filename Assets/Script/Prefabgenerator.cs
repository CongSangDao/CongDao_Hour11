using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;

public class Prefabgenerator : MonoBehaviour
{
    public Vector3[]lampPositions;
    public GameObject prefab;
    public Vector3 spawnPosition;
    public int numLampsToSpawn = 10;
    public float offset = 2f;
    
    void Start()
    {
        spawnPosition = transform.position;
        for (int i = 0; i < lampPositions.Length; i++)
        {
            Instantiate(prefab, lampPositions[i], Quaternion.identity);
        }

        for (int i = 0; i < numLampsToSpawn; i++)
        {
            Instantiate(prefab, spawnPosition, Quaternion.Euler(0, 90, 0));
            spawnPosition += Vector3.forward * offset;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
