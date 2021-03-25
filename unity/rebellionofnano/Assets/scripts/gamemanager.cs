using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public float health = 100f;
    public float sheild = 0f;
    public cameramove cameramove;
    public float sheildDisplay = 0f;
    public WallRunTutorial wallrunscript;
    public bool persons = false;
    private void Update()
    {
        if (sheild <= -1f)
        {
            health += sheild;
        }
        sheildDisplay = sheild * 2f;
    }
    public void damage (float howmuchdamage)
    {
        if (sheild >= 1f)
        {
            sheild -= howmuchdamage;
        }
        else
        {
            health -= howmuchdamage;
        }
        if (health <= 0f)
        {
            death();
        }
    }
    public void death()
    {
        //wait for a little bit
        //say you died
        //menu
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "kill")
        {
            death();
        }

    }
    public void thirdperson()
    {
        if (persons == false)
        {
            persons = true;
        }
        else
        {
            persons = false;
        }
    }
}