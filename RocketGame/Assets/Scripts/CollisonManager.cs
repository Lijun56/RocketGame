using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisonManager : MonoBehaviour
{
    //whenever hit other object we do switch statement
    void OnCollisionEnter(Collision other) 
    {
        switch(other.gameObject.tag)
        {
            case "friendly":
                Debug.Log("friend");
                break;
            case "Finish":
                LoadNextLevel();
                break;
            default:
                Debug.Log("fail");
                LoadRestart();
                break;    
        }   
    }
    void LoadNextLevel(){
        GetComponent<Movement>().enabled = false;
        Invoke("NextLevel", 2f);
    }
    void LoadRestart(){
        GetComponent<Movement>().enabled = false;
        Invoke("Restart",1f);
    }
    void NextLevel(){

        int NextSceneIndex = SceneManager.GetActiveScene().buildIndex+1;
        if ( NextSceneIndex == 0){
            NextSceneIndex = 0;
        }
        SceneManager.LoadScene(NextSceneIndex);
    }
    void Restart(){

        // SceneManager.LoadScene(0); load scene with index number 0
        //reload the current scene
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex);
    }
}
