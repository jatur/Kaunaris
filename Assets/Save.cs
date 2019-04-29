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
    public List<SightData> nope;
    
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
        data = GetHardcodedData();
        nope = new List<SightData>();
        isSight = true;
        isSport = true;
        isRestaurant = true;
        isBar = true;
        isSupermarket = true;
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

    public List<SightData> Nope
    {
        get => nope;
        set => nope = value;
    }

    public List<SightData> GetHardcodedData()
    {
        List<SightData> data = new List<SightData>();
        data.Add(new SightData("Maxima", "10", "", "Maxima", "/Maxima+XX,+Jonavos+gatv%C4%97,+Kaunas", 9, "http://volfasengelman.lt/", false, false, false, false, true));
        data.Add(new SightData("Town Hall", "16", "", "TownHall", "/Kaunas+Town+Hall,+Rotu%C5%A1%C4%97s+a.+15,+Kaunas+44279", 15, "http://volfasengelman.lt/", true, false, false, false, false));
        data.Add(new SightData("Kaunas Castle (Kauno pilis)", "6", "", "Castle", "/Kaunas+Castle,+Rotu%C5%A1%C4%97s+aik%C5%A1t%C4%97,+Kaunas", 5, "http://www.autc.lt/lt/architekturos-objektai/1130", true, false, false, false, false));
        data.Add(new SightData("The Church of Vytautas the Great", "8", "", "Church", "/Vytauto+Did%C5%BEiojo+%C5%A0v%C4%8D.+Mergel%C4%97s+Marijos+%C4%97mimo+%C4%AF+dang%C5%B3+ba%C5%BEny%C4%8Dia,+Aleksoto+gatv%C4%97,+Kaunas", 7, "http://www.autc.lt/lt/architekturos-objektai/1130", true, false, false, false, false));
        data.Add(new SightData("Volfas Engelman brewery", "14", "", "Brewery", "/Volfas+Engelman+Studija,+Kaunakiemio+gatv%C4%97,+Kaunas", 13, "http://volfasengelman.lt/", true, false, true, true, false));
        data.Add(new SightData("Dariaus Ir Gireno Stadium", "12", "", "Stadium", "/S.+Darius+and+S.+Gir%C4%97no+stadium,+Kaunas", 11, "http://volfasengelman.lt/", true, true, false, true, false));
        return data;
    }
}
