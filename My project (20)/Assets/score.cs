using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class score : MonoBehaviour
{
public Transform player;
public  TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
       text.text=player.position.z.ToString("0");
    }
}
