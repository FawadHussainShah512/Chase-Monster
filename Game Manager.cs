using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SeriallizeField]
    private gameObject characters;

    private int _charIndex;
    public int charIndex{
        get{return _charIndex;}
        set{_charIndex=value;}
    }

    private void Awake(){
        if(instance==null)
        {
            instance=this;
            DontDestroyOnLoad(gameObject);

        }
        else{
            Destroy(gameObject);

        }
    }

    private void OnEnable(){
        SceneManager.sceneload += OnLevelFinishedLoading;
    }

    private void OnDisable(){
        SceneManager.sceneload -= OnLevelFinishedLoading;
    }
   
   void OnLevelFinishedLoading(Scene scene,LoadSceneMode mode){
    if(scene.name=="Gameplay"){
        SceneManager.LoadScene("Gameplay");
    }

   }
   
}
