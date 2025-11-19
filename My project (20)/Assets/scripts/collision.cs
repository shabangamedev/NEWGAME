using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collisioninfo ) 
    {
        if(collisioninfo.collider.name=="player")
        {
            boxCollider.enabled = false;    
        }
    }
}
