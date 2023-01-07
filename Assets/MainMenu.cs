using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;

public class MainMenu : MonoBehaviour
{
    private void Awake()
    {
        if (!Application.isEditor)
        {
            // ask user permission to use the GPS
            if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
                Permission.RequestUserPermission(Permission.FineLocation);
            // ask user permission to use the Camera
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
                Permission.RequestUserPermission(Permission.Camera);
        }
        
    }
    
    public void FIK() {
        SceneManager.LoadScene("FIK");
    }

    public void FEB() {
        SceneManager.LoadScene("FEB");
    }

    public void FH() {
        SceneManager.LoadScene("FH");
    }

    public void FK() {
        SceneManager.LoadScene("FK");
    }

    public void FISIP() {
        SceneManager.LoadScene("FISIP");
    }

    public void Kos() {
        SceneManager.LoadScene("Kos");
    }

    public void Quit() {
        Application.Quit();
    }
}
