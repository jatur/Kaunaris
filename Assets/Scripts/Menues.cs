using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menues : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Quit!");

        string m_Path = Application.dataPath;
        Debug.Log("Path : " + m_Path);
    }

    public void StartSwipe()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToStart()
    {
        SceneManager.LoadScene(0);
    }
    public void JumpToFilter()
    {
        SceneManager.LoadScene(2);
    }
    public void JumpToAR()
    {
        SceneManager.LoadScene(3);
    }

    public void JumpToMaps()
    {
        SceneManager.LoadScene(4);
    }
    
}
