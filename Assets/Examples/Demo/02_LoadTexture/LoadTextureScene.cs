using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SwipeableView
{
    public class LoadTextureScene : MonoBehaviour
    {
        [SerializeField]
        private UISwipeableViewLoadTexture swipeableView;
        
        private List<SightData> fav = new List<SightData>();
        private List<SightData> data = new List<SightData>();

        public bool aractive = false;
        

        void Start()
        {
            data = GetHardcodedData();
            
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            Debug.Log(component.Data.Count);
            Debug.Log(data.Count);
            if (component.Data.Count!=data.Count&&component.Data.Count>0)
            {
                fav = component.Fav;
                data = component.Data;

            }
            swipeableView.UpdateData(data);
        }

        public void OnClickLike()
        {
            swipeableView.AutoSwipeTo(Direction.Right);
        }
        
        public void OnClickRoute()
        {
            String url = "https://www.google.com/maps/dir";
            Debug.Log(fav.Count);
            swipeableView.getFav().ForEach(data => url+=data.mapsURL);
            Application.OpenURL(url);
        }

        public void onCLickAR()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            component.Fav = swipeableView.getFav();
            component.Data = swipeableView.getData();
            SceneManager.LoadScene(swipeableView.getData()[0].textureSceneID);
            aractive = true;
        }

        public void OnClickNope()
        {
            swipeableView.AutoSwipeTo(Direction.Left);
        }
        
        public List<SightData> GetHardcodedData()
        {
            List<SightData> data = new List<SightData>();
            data.Add(new SightData("Building","Info","Beast Info","1","/Kauno+karo+medicinos+centras",3,"www.google.de"));
            data.Add(new SightData("Building","Info","Beast Info","2","/Ramyb%C4%97s+parkas,+Kaunas+44329",3,"www.google.de"));
            return data;
        }
    }
}