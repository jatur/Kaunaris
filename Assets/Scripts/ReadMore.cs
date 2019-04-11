using System;
using UnityEngine;
public class ReadMore : MonoBehaviour
{

     public void ReadMoreCaste()
    {
        String url = "http://www.autc.lt/lt/architekturos-objektai/1130";

        Application.OpenURL(url);
    }

    public void ReadMoreGeneric(String url)
    {
        Application.OpenURL(url);
    }



}
