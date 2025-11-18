
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
            rb.AddForce(sd *Time.deltaTime, 0, 0,ForceMode.VelocityChange );
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sd*Time.deltaTime, 0, 0,ForceMode.VelocityChange );
        }
        
    
        
    }
}
