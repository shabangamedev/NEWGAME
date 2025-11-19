using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevelUI : MonoBehaviour
{
    
  public void OnTriggerEnter()
    {
        FindObjectOfType<GameManament>().CompleteLevel();
    }
}
