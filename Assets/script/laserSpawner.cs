using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Laser laser;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if (laser == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
        GameObject laserGO = Instantiate(prefab);
        laser = laserGO.GetComponent<Laser>();
    }

    void Fire()
    {
        laser.laserShot = true;
        laser = null;
    }
}
