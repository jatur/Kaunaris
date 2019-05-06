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
        private GameObject[] _gameObjects1;


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
                foreach (GameObject o in _gameObjects1)
                {
                    o.SetActive(true);
                }
            }
        }

        void Start()
        {
            _gameObjects1 = GameObject.FindGameObjectsWithTag("TinderHide");
            _gameObjects = GameObject.FindGameObjectsWithTag("TinderHide");
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            isSight = component.IsSight;
            isSport = component.IsSport;
            isRestaurant = component.IsRestaurant;
            isBar = component.IsBar;
            isSupermarket = component.IsSupermarket;

            data = component.GetHardcodedData();
            fav = component.Fav;
            nope = component.Nope;
            Debug.Log("Nope: " + nope.Count);
            Debug.Log("Fav: " + fav.Count);
            
            
            fav.ForEach(x =>
            {
                if (data.Contains(x))
                {
                    data.Remove(x);
                }
            });
            nope.ForEach(x =>
            {
                if (data.Contains(x))
                {
                    data.Remove(x);
                }

            });

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

            Debug.Log("Data:" + data.Count);
            data.ForEach(x => Debug.Log(x.name));
            
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
            component.Fav = swipeableView.getFav();
            component.Data = swipeableView.getData();
            component.Nope = swipeableView.getNope();
            Debug.Log("SAVE START");
            Debug.Log("Data: " + component.data.Count);
            Debug.Log("Fav: " + component.fav.Count);
            Debug.Log("Nope: " + component.nope.Count);
            Debug.Log("SAVE END");
        }
        
        public void loadDefault()
        {
            var component = GameObject.Find("DefaultSave").GetComponent<Save>();
            component.Fav = new List<SightData>();
            component.Data = component.GetHardcodedData();
            component.Nope = new List<SightData>();
        }

        public void OnClickNope()
        {
            swipeableView.AutoSwipeTo(Direction.Left);
        }

    }
}