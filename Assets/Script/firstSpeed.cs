
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstSpeed : MonoBehaviour
{

    public float speed = 5.0f;
    float lastSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lastSpeed = speed * 2;
        Vector3 su = new Vector3(0, lastSpeed, 0);
        GetComponent<Rigidbody>().velocity = su;
    }
}

