using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -5 * Time.deltaTime);
        //Vector3 rot = transform.eulerAngles;
        //rot.z += 1;
        //transform.eulerAngles = rot;


    }
}

