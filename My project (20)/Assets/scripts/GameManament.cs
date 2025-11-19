using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManament : MonoBehaviour
{
  bool endgame=false;
  public float Delay=2;
  public GameObject LevelCompleteUI;
  public void CompleteLevel ()
    {
        LevelCompleteUI. SetActive(true);
    }
    public void EndGame()
    {
        if (endgame==false)
        {
            endgame=true;   
        Debug.Log("endgame");
        Invoke("Restart",Delay);    
        }
      
}
void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}


 