using System;
using System.Collections.Generic;
using System.Drawing;

namespace InformationKeeper
{
    [Serializable]
    class Album : IData
    {
        private List<byte[]> images;

        public object this[string field]
        {
            get
            {
                if (field == "images")
                {
                    this.images = this.images.Encrypt(169);

                    Image[] images = new Image[this.images.Count];
                    for (int i = 0; i < images.Length; i++)
                        images[i] = this.images[i].GetImage();

                    this.images = this.images.Encrypt(169);

                    return images;
                }
                throw new ArgumentException("field wasn`t founded");
            }
            set
            {
                if (field == "images")
                {
                    List<byte[]> images = new List<byte[]>();
                    for (int i = 0; i < (value as Image[]).Length; i++)
                        images.Add((value as Image[])[i].GetBytes());

                    this.images = images.Encrypt(169);
                }
                else
                    throw new ArgumentException("field wasn`t founded");
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public Album(string name, string description, Image[] images)
        {
            Name = name;
            Description = description;

            this.images = new List<byte[]>();
            foreach (Image image in images)
                this.images.Add(image.GetBytes());
            this.images = this.images.Encrypt(169);
        }

        public void AddImage(Image image)
        {
            images = images.Encrypt(169);
            images.Add(image.GetBytes());
            images = images.Encrypt(169);
        }

        public void RemoveImage(Image image)
        {
            images = images.Encrypt(169);
            images.Remove(image.GetBytes());
            images = images.Encrypt(169);
        }
    }
}
