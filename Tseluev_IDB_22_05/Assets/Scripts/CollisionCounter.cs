using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCOunter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
            Counter.count += 1;
            Move.speed = -(Move.speed);
    }
}
