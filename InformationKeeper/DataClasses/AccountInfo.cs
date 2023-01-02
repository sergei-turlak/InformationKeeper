using System;

namespace InformationKeeper
{
    [Serializable]
    class AccountInfo : IData
    {
        private byte[] login;
        private byte[] password;
        private byte[] email;
        private byte[] number;


        public string Name { get; set; }
        public string Description { get; set; }

        public object this[string field]
        {
            get
            {
                if (field == "login")
                    return login.GetString(169);
                else if (field == "password")
                    return password.GetString(169);
                else if (field == "email")
                    return email.GetString(169);
                else if (field == "number")
                    return number.GetString(169);
                throw new ArgumentException("field wasn`t founded");
            }
            set
            {
                if (field == "login")
                    login = (value as string).GetBytes(169);
                else if (field == "password")
                    password = (value as string).GetBytes(169);
                else if (field == "email")
                    email = (value as string).GetBytes(169);
                else if (field == "number")
                    number = (value as string).GetBytes(169);
                else
                    throw new ArgumentException("field wasn`t founded");
            }
        }

        public AccountInfo(string name, string descrip, string login, string password, string email, string number)
        {
            Name = name;
            Description = descrip;
            this.login = login.GetBytes(169);
            this.password = password.GetBytes(169);
            this.email = email.GetBytes(169);
            this.number = number.ToString().GetBytes(169);
        }
    }
}
