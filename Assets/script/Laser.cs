using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //varibles for laser
    public float speed = 3;
    public bool laserShot = false;
    public Transform Arwing;
    void Update()
    {
        if (laserShot == true)
        {
            Movement();
        }
        else
        {
            PointAtMouse();
        }
    }
    //laser faces mouse
    void PointAtMouse()
    {
        //arwing transform varible to drag the arwing into the script
        transform.position = Arwing.transform.position;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }
    //movement for laser
    void Movement()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
