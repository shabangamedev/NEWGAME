using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameobject : MonoBehaviour
{
    bool endgame=false;
    void EndGame()
    {
        if (endgame==true)
        {
        Debug.Log("endgame");    
        }
       
    }
}
