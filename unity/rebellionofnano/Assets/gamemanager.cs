using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public float health = 100f;
    public float sheild = 0f;
    public float sheildDisplay = 0f;
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
    }
    public void death()
    {
        // wait for a little bit 
        //say you died
        //menu
    }
}