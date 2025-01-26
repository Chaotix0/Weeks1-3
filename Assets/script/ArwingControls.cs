using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwingControls : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;

        Vector2 screenPos = Camera.main.ScreenToWorldPoint(pos);
        pos.x += speed;

        //Stopping the Arwing from going off screen
        //x/horizontal value
        if (pos.x < -11 || pos.x > 11) { 
            speed = speed * 1;
        }
        //y/height value
        if (pos.y < -5 || pos.y > 5)
        {
            speed = speed * -1;
        }
    }
}
