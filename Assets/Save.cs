using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    public List<SightData> Fav1
    {
        get => fav;
        set => fav = value;
    }

    public List<SightData> Data1
    {
        get => data;
        set => data = value;
    }

    public bool IsSight
    {
        get => isSight;
        set => isSight = value;
    }

    public bool IsSport
    {
        get => isSport;
        set => isSport = value;
    }

    public bool IsRestaurant
    {
        get => isRestaurant;
        set => isRestaurant = value;
    }

    public bool IsBar
    {
        get => isBar;
        set => isBar = value;
    }

    public bool IsSupermarket
    {
        get => isSupermarket;
        set => isSupermarket = value;
    }

    public List<SightData> fav;

    public List<SightData> data;
    
    public bool isSight;
    public bool isSport;
    public bool isRestaurant;
    public bool isBar;
    public bool isSupermarket;
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(GameObject.Find("DefaultSave"));   
    }

    void Start()
    {
        fav = new List<SightData>();
        data = new List<SightData>();
        SceneManager.LoadScene(0);
    }

    public List<SightData> Fav
    {
        get => fav;
        set => fav = value;
    }

    public List<SightData> Data
    {
        get => data;
        set => data = value;
    }
}
