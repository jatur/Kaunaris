using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace SwipeableView
{
    public class UISwipeableViewLoadTexture : UISwipeableView<SightData>
    {
        public void UpdateData(List<SightData> data)
        {
            base.Initialize(data);
        }

        public List<SightData> getFav()
        {
            return base.Fav;
        }

        public List<SightData> getData()
        {
            return base.Data;
        }
    }
}