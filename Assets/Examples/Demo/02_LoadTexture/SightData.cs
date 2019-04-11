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

        public SightData(string name, string info, string beastInfo, string image, string mapsUrl, int textureSceneId, string link)
        {
            this.name = name;
            this.info = info;
            this.beastInfo = beastInfo;
            this.image = image;
            mapsURL = mapsUrl;
            textureSceneID = textureSceneId;
            this.link = link;
        }
    }
}