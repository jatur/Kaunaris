using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace SwipeableView
{
    public class UISwipeableViewBasic : UISwipeableView<SightData>
    {
        public void UpdateData(List<SightData> data)
        {
            base.Initialize(data);
        }
    }
}