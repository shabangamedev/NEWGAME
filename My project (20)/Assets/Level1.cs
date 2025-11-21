using UnityEngine;
using UnityEngine.SceneManagement;
public class Level1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

   
}
