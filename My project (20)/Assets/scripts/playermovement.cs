
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sd = 10;
    public float ff = 10;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ff*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sd *Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sd*Time.deltaTime, 0, 0);
        }
         if (Input.GetKeyUp("w"))
        {
            rb.AddForce(0, sd*Time.deltaTime, 0);
        }
    
        
    }
}
