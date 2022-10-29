using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCiickEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
