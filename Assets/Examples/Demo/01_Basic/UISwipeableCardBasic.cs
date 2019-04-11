using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

namespace SwipeableView
{
    public class UISwipeableCardBasic : UISwipeableCard<SightData>
    {
        [SerializeField]
        private Image bg;

        [SerializeField]
        private CanvasGroup imgLike;

        [SerializeField]
        private CanvasGroup imgNope;

        public override void UpdateContent(SightData data)
        {

            bg = null;

            imgLike.alpha = 0;
            imgNope.alpha = 0;
        }

        public override void SwipingToRight(float rate)
        {
            imgLike.alpha = rate;
            imgNope.alpha = 0;
        }

        public override void SwipingToLeft(float rate)
        {
            imgNope.alpha = rate;
            imgLike.alpha = 0;
        }
    }
}