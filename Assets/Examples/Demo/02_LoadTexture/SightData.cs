using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class SightData
    {
        public String name;
        public String info;
        public String beastInfo;
        public String image;
        public String mapsURL;
        public int textureSceneID;
        public String link;
        public bool isSight;
        public bool isSport;
        public bool isRestaurant;
        public bool isBar;
        public bool isSupermarket;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Info
        {
            get => info;
            set => info = value;
        }

        public string BeastInfo
        {
            get => beastInfo;
            set => beastInfo = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string MapsUrl
        {
            get => mapsURL;
            set => mapsURL = value;
        }

        public int TextureSceneId
        {
            get => textureSceneID;
            set => textureSceneID = value;
        }

        public string Link
        {
            get => link;
            set => link = value;
        }

        public SightData(string name, string info, string beastInfo, string image, string mapsUrl, int textureSceneId, string link, bool isSight, bool isSport, bool isRestaurant, bool isBar, bool isSupermarket)
        {
            this.name = name;
            this.info = info;
            this.beastInfo = beastInfo;
            this.image = image;
            mapsURL = mapsUrl;
            textureSceneID = textureSceneId;
            this.link = link;
            this.isSight = isSight;
            this.isSport = isSport;
            this.isRestaurant = isRestaurant;
            this.isBar = isBar;
            this.isSupermarket = isSupermarket;
        }
        
        public override bool Equals(object obj)
        {
            var item = obj as SightData;
            
            if (item == null)
            {
                return false;
            }

            return this.textureSceneID.Equals(item.textureSceneID);
        }
    }
    
}