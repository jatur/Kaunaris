using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class ListList : MonoBehaviour
{
    public ListList(List<SightData> data, List<SightData> fav)
    {
        this.data = data;
        this.fav = fav;
    }

    private List<SightData> data;
    private List<SightData> fav;

    public List<SightData> Data
    {
        get => data;
        set => data = value;
    }

    public List<SightData> Fav
    {
        get => fav;
        set => fav = value;
    }
}
