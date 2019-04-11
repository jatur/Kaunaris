using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

namespace SwipeableView
{
    public class BasicScene : MonoBehaviour
    {
        [SerializeField]
        private UISwipeableViewBasic swipeableView;


        public Image building;
        
        void Start()
        {
            swipeableView.UpdateData(GetHardcodedData());
        }

        public void OnClickLike()
        {
            swipeableView.AutoSwipeTo(Direction.Right);
        }

        public void OnClickNope()
        {
            swipeableView.AutoSwipeTo(Direction.Left);
        }

        public void OnClickRoute()
        {
            
        }

        public List<SightData> GetHardcodedData()
        {
            List<SightData> data = new List<SightData>();
            data.Add(new SightData("Building","Info","Beast Info",null,"mapsURL",0,"www.google.de"));
            return data;
        }
    }
   
}