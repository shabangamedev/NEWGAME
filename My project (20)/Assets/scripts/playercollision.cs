
using UnityEngine;

public class playercollision : MonoBehaviour
{
    // Start is called before the first frame update
    public playermovement movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obsticls")
        {

            movement.enabled = false;
            
            FindObjectOfType<GameManament>().EndGame();
            

        }
        
        
         
        
    }
}
