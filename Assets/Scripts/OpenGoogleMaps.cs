﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DefaultNamespace;
using SwipeableView;
using UnityEngine;

public class OpenGoogleMaps : MonoBehaviour
{

    public void OpenRoute()
    {
        String url = "https://www.google.com/maps/dir";

        var texture =  GetComponent<UISwipeableView<SightData, SwipeableViewNullContext>>();
        texture.Fav.ForEach(data => url+=data.mapsURL);
        Application.OpenURL(url);
    }
}
