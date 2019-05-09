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
        private List<SightData> nope = new List<SightData>();
        private List<SightData> data = new List<SightData>();

        
        public bool isSight;
        public bool isSport;
        public bool isRestaurant;
        public bool isBar;
        public bool isSupermarket;
        private GameObject[] _gameObjects;


        private void Update()
        {
            if (data.Count == 0)
            {
                foreach (GameObject o in _gameObjects)
                {
                    o.SetActive(false);
                }
            }
            else
            {
                foreach (GameObject o in _gameObjects)
                {
                    o.SetActive(true);
                }
            }
        }

        void Start()
        {
            _gameObjects = GameObject.FindGameObjectsWithTag("TinderHide");
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            isSight = component.IsSight;
            isSport = component.IsSport;
            isRestaurant = component.IsRestaurant;
            isBar = component.IsBar;
            isSupermarket = component.IsSupermarket;

            data = component.GetData();
            fav = component.Fav;
            nope = component.Nope;

            List<SightData> tmp = new List<SightData>();

            if (isSight)
            {
                data.ForEach(x =>
                {
                    if (x.isSight==component.isSight&&!tmp.Contains(x))
                    {
                        tmp.Add(x);
                    }
                });
            }
            if (isBar)
            {
                data.ForEach(x =>
                {
                    if (x.isBar==component.IsBar&&!tmp.Contains(x))
                    {
                        tmp.Add(x);
                    }
                });
            }
            if (isSport)
            {
                data.ForEach(x =>
                {
                    if (x.isSport==component.IsSport&&!tmp.Contains(x))
                    {
                        tmp.Add(x);
                    }
                });
            }
            if (isRestaurant)
            {
                data.ForEach(x =>
                {
                    if (x.isRestaurant==component.IsRestaurant&&!tmp.Contains(x))
                    {
                        tmp.Add(x);
                    }
                });
            }
            if (isSupermarket)
            {
                data.ForEach(x =>
                {
                    if (x.isSupermarket==component.IsSupermarket&&!tmp.Contains(x))
                    {
                        tmp.Add(x);
                    }
                });
            }

            data = tmp;
            
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
            Application.OpenURL(url);
            SceneManager.LoadScene(1);
            loadDefault();
        }

        public void onCLickAR()
        {
            save();
            SceneManager.LoadScene(swipeableView.getData()[0].textureSceneID);
        }

        public void onCLickInfo()
        {
            save();
            SceneManager.LoadScene(Int32.Parse(swipeableView.getData()[0].info));
        }

        public void save()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            component.checkData();
        }
        
        public void loadDefault()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            component.Fav = new List<SightData>();
            component.data = component.GetHardcodedData();
            component.Nope = new List<SightData>();
        }

        public void OnClickNope()
        {
            swipeableView.AutoSwipeTo(Direction.Left);
        }

    }
}