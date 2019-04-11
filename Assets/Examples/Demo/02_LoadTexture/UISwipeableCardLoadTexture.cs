using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

namespace SwipeableView
{
    public class UISwipeableCardLoadTexture : UISwipeableCard<SightData>
    {
        [SerializeField] private RawImage image;

        [SerializeField] private CanvasGroup imgLike;

        [SerializeField] private CanvasGroup imgNope;

        public override void UpdateContent(SightData data)
        {
            if (data.image==null)
            {
                Debug.Log(data.ToString());
            }

            image.texture = Resources.Load<Texture2D>(data.image);
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