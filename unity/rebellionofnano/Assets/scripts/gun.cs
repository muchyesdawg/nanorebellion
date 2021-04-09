using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    //values
    public Rigidbody rb;
    public float damage = 20f;
    public float range = 100f;

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
        if(rwegrapple == false)
        {
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }

    }

    void shoot()
    {
        RaycastHit hitinfo;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitinfo, range))
        {
            Debug.Log(hitinfo.transform.name);
            GameObject grapplepoint = Instantiate(grappling, hitinfo.point, Quaternion.LookRotation(hitinfo.normal));
            rwegrapple = true;
            Vector3 grappleposition = grapplepoint.transform.position;
            transform.Translate(grappleposition);

        }
    }
}