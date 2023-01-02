using System;

namespace InformationKeeper
{
    [Serializable]
    class Note : IData
    {
        private byte[] content;

        public string Name { get; set; }
        public string Description { get; set; }

        public object this[string field]
        {
            get
            {
                if (field == "content")
                    return content.GetString(169);
                throw new ArgumentException("field wasn`t founded");
            }
            set
            {
                if (field == "content")
                    content = (value as string).GetBytes(169);
                else
                    throw new ArgumentException("field wasn`t founded");
            }
        }


        public Note(string name, string description, string content)
        {
            Name = name;
            Description = description;
            this.content = content.GetBytes(169);
        }
    }
}
