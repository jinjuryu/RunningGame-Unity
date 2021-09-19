using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject image, main;
    
    public void PlayGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }
    public void HowToPlay()
    {
        main.gameObject.SetActive(false);
        image.gameObject.SetActive(true);
    }
    public void Restart()
    {
        
        SceneManager.LoadScene("Main");
    }


    public void BacktoMain()
    {
        image.gameObject.SetActive(false);
        main.gameObject.SetActive(true);
    }


}
