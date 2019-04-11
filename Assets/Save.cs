using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{

    public List<SightData> fav;

    public List<SightData> data;
    // Start is called before the first frame update
    void Start()
    {
        fav = new List<SightData>();
        data = new List<SightData>();
        DontDestroyOnLoad(GameObject.Find("DefaultSave"));
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public ListList saveData(List<SightData> data, List<SightData> fav)
    {
        return new ListList(data,fav);
    }
    
     
}
