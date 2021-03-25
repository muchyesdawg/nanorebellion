using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlook : MonoBehaviour
{
    public Transform player;
    public float sensitivity = 10f;

    float x = 0f;
    float y = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //input
        x += -Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        y += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        //clamping
        x = Mathf.Clamp(x, 90, -90);
        //rotation
        transform.localRotation = Quaternion.Euler(x, 0, 0);
        player.transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
