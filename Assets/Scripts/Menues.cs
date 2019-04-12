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
        SceneManager.LoadScene(2);
    }

    public void BackToStart()
    {
        SceneManager.LoadScene(1);
    }
    public void JumpToFilter()
    {
        SceneManager.LoadScene(3);
    }
    public void JumpToAR()
    {
        SceneManager.LoadScene(4);
    }

    public void JumpToMaps()
    {
        SceneManager.LoadScene(5);
    }

    public void JumpToInfoOfChirch()
    {
        SceneManager.LoadScene(6);
    }

}
