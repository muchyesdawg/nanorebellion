using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typetwograpplle : MonoBehaviour
{
    //values
    public Rigidbody rb;
    public float damage = 20f;
    public float range = 100f;

    //rotation
    float x, y, z;
    //refrence GameObjects
    public GameObject grappling;
    public Transform fpsCam;

    // grapple
    bool rwegrapple = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
        if (rwegrapple == false)
        {
            rb.useGravity = true;
        }
        else
        {
            rb.useGravity = false;
            transform.Translate(x, y, z);

        }

    }

    void shoot()
    {
        if (rwegrapple == false)
        {
            rwegrapple = true;
            x = fpsCam.transform.rotation.x;
            y = fpsCam.transform.rotation.y;
            z = fpsCam.transform.rotation.z;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (rwegrapple == true)
        {
            rwegrapple = false;
        }

    }
}
