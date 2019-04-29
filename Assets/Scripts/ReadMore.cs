using System;
using UnityEngine;
public class ReadMore : MonoBehaviour
{

     public void ReadMoreCaste()
    {
        String url = "https://www.pamatyklietuvoje.lt/details/kauno-pilis/2174";

        Application.OpenURL(url);
    }
    public void ReadMoreChurch()
    {
        String url = "http://www.autc.lt/lt/architekturos-objektai/1130";

        Application.OpenURL(url);
    }
    public void ReadMoreMaxima()
    {
        String url = "https://www.maxima.lt/";

        Application.OpenURL(url);
    }
    public void ReadMoreStadium()
    {
        String url = "https://www.facebook.com/pages/Darius-and-Gir%C4%97nas-Stadium/348446041900929";

        Application.OpenURL(url);
    }
    public void ReadMoreTownHall()
    {
        String url = "http://kaunomuziejus.lt/rotuses_skyrius/?lang=en";

        Application.OpenURL(url);
    }
    public void ReadMoreVolfas()
    {
        String url = "http://volfasengelman.lt/";

        Application.OpenURL(url);
    }

    public void ReadMoreGeneric(String url)
    {
        Application.OpenURL(url);
    }

    public void ReadMore2022()
    {
        Application.OpenURL("https://kaunas2022.eu/");
    }



}
