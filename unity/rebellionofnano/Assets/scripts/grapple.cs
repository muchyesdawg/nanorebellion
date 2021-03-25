using UnityEngine;

public class grapple : MonoBehaviour {
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask WhatIsGrappleable;
    void Awake(){
        lr = GetComponent<LineRenderer>();
    }
}