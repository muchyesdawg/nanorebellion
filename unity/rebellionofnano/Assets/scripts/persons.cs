using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persons : MonoBehaviour
{
	public Transform thirdperson;
	public gamemanager gamemanager;
	public Transform camera;


    // Update is called once per frame
    void Update()
    {
		if (gamemanager.persons == false){
			transform.position = thirdperson.transform.position;
		}
		else{
			transform.position = camera.transform.position;
		}
    }
}