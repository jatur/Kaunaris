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
        
        public bool isSight;
        public bool isSport;
        public bool isRestaurant;
        public bool isBar;
        public bool isSupermarket;

        void Start()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            isSight = component.IsSight;
            isSport = component.IsSport;
            isRestaurant = component.IsRestaurant;
            isBar = component.IsBar;
            isSupermarket = component.IsSupermarket;

            data = component.Data;
            var savedData = component.Data;

            List<SightData> tmp = new List<SightData>();

            if (component.IsSight)
            {
                data.Where(x => x.isSight == component.IsSight).ToList().ForEach(x => tmp.Add(x));
            }
            if (component.IsBar)
            {
                data.Where(x => x.isBar == component.IsBar).ToList().ForEach(x => tmp.Add(x));
            }
            if (component.IsSport)
            {
                data.Where(x => x.isSport == component.IsSport).ToList().ForEach(x => tmp.Add(x));
            }
            if (component.IsRestaurant)
            {
                data.Where(x => x.isRestaurant == component.IsRestaurant).ToList().ForEach(x => tmp.Add(x));
            }
            if (component.IsSupermarket)
            {
                data.Where(x => x.isSupermarket == component.IsSupermarket).ToList().ForEach(x => tmp.Add(x));
            }

            data = tmp;
            Debug.Log("DATACOUNTER ___ : " + data.Count);
            data.ForEach(x => Debug.Log(x.link));


            Debug.Log("CDC: " + component.Data.Count);
            Debug.Log("DC: " + data.Count);

                fav = component.Fav;
        

        
            
            swipeableView.UpdateData(data);
        }

        public void OnClickLike()
        {
            swipeableView.AutoSwipeTo(Direction.Right);
        }
        
        public void OnClickRoute()
        {
            String url = "https://www.google.com/maps/dir/Kaunas+University+of+Technology,+K.+Donelai%C4%8Dio+gatv%C4%97,+Kaunas";
            Debug.Log(fav.Count);
            swipeableView.getFav().ForEach(data => { url += data.mapsURL; Debug.Log(data.mapsURL); });
            Debug.Log(url);
            Debug.Log("WHAT IS GOING ON HEEEERE");
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

        public void onCLickInfo()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            component.Fav = swipeableView.getFav();
            component.Data = swipeableView.getData();
            SceneManager.LoadScene(Int32.Parse(swipeableView.getData()[0].info));
            aractive = true;
        }

        public void save()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            component.Fav = swipeableView.getFav();
            component.Data = swipeableView.getData();
        }

        public void OnClickNope()
        {
            swipeableView.AutoSwipeTo(Direction.Left);
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
}