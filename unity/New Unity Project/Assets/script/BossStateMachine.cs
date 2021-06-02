using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateMachine : MonoBehaviour
{
    bool NewStage, Stage1, Stage2, Stage3;
    public float HealthInStage, HealthOverall, HealthInStageFull;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.transform.layer == "bullet"){
            HealthInStage
        }
    }
}
