using System;
using System.Collections.Generic;
using System.Drawing;

namespace InformationKeeper
{
    [Serializable]
    public class Account
    {
        private byte[] name;
        private byte[] password;
        public Image Avatar { get; set; }
        public List<IData> Data { get; set; }

        public string Name
        {
            get
            {
                return name.GetString(169);
            }
            set
            {
                name = value.GetBytes(169);
            }
        }
        public string Password
        {
            get
            {
                return password.GetString(169);
            }
            set
            {
                password = value.GetBytes(169);
            }
        }

        public Account(string name, string pass, Image avatar)
        {
            Name = name;
            Password = pass;
            Avatar = avatar;
            Data = new List<IData>();
        }
    }
}
