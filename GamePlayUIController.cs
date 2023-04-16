using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayUIController : MonoBehaviour
{
    
   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
           SceneManager.LoadScene("MainMenu");
    }

   
}
