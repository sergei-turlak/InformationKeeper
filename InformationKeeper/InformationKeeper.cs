using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace InformationKeeper
{
    [Serializable]
    static class InformationKeeper
    {
        public static string AccountsFileName { get; } = Application.StartupPath + "\\accounts.dat";
        public static string InfoFileName { get; } = Application.StartupPath + "\\info.dat";
        public static Account Current { get; set; }

        /// <summary>
        /// Обновляет конкретные данные в аккаунте по старому названии.
        /// </summary>
        public static void UpdateData(Account account, string oldDataName, IData targetData)
        {
            if (DataExists(account, (d) => d.Name == oldDataName))
            {
                RemoveData(account, GetData(account, (d) => d.Name == oldDataName));
                SaveData(account, targetData);
            }
            else
                throw new Exception("account haven`t been founded to update it");
        }

        /// <summary>
        /// Удаляет конкретные данные в аккаунте.
        /// </summary>
        public static void RemoveData(Account account, IData data)
        {
            if (DataExists(account, (d) => d.Name == data.Name))
            {
                var accounts = LoadAccounts();
                accounts.Remove(accounts.Find((acc) => acc.Name == account.Name));
                RemoveAccount(account);
                account.Data.Remove(account.Data.Find((d) => d.Name == data.Name));
                accounts.Add(account);
                Serialize(accounts, AccountsFileName);
            }
            else
                throw new Exception("data haven`t been founded to remove it");
        }

        /// <summary>
        /// Проверяет существуют ли конкретные данные в аккаунте.
        /// </summary>
        public static bool DataExists(Account account, Predicate<IData> match)
        {
            if (account.Data.Count == 0)
                return false;
            return account.Data.Exists(match);
        }

        /// <summary>
        /// Возвращает кокретные данные из аккаунта с заданным фильтром.
        /// </summary>
        public static IData GetData(Account account, Predicate<IData> match)
        {
            return account.Data.Find(match);
        }

        /// <summary>
        /// Сериализует данные в аккаунт.
        /// </summary>
        public static void SaveData(Account account, IData data)
        {
            account.Data.Add(data);
            UpdateAccount(account.Name, account);
        }

        /// <summary>
        /// Сериализует некоторую информацию о приложении: автовход в какой-либо аккаунт и прочье.
        /// </summary>
        /// <param name="autoSave"> Будет ли при запуске приложение выполнятся автозаполнение данных и вход.</param>
        /// <param name="account"> Имя аккаунта, вход в который будет автоматически выполнятся если параметр autoSave устанвлен true.</param>
        public static void SaveInfo(bool autoSave, string accountName)
        {
            Serialize(new object[] { autoSave, accountName }, InfoFileName);
        }

        /// <summary>
        /// Десериализует некоторую информацию о приложении: автовход в какой-либо аккаунт и прочье.
        /// </summary>
        public static (bool autoLogin, string accountName) LoadInfo()
        {
            object[] info = (object[])Deserialize(InfoFileName);
            if (info == null)
            {
                return (false, "");
            }
            return ((bool)info[0], (string)info[1]);
        }

        /// <summary>
        /// Добавляет в сериализованный список аккаунтов заданный аккаунт.
        /// </summary>
        public static void SaveAccount(Account account)
        {
            var accounts = LoadAccounts();
            accounts.Add(account);
            Serialize(accounts, AccountsFileName);
        }

        /// <summary>
        /// Десериализует и возвращает объект типа List<Account> где хранятся авторизованные аккаунты. 
        /// </summary>
        public static List<Account> LoadAccounts()
        {
            var accounts = (List<Account>)Deserialize(AccountsFileName);
            if (accounts == null)
                accounts = new List<Account>();
            return accounts;
        }

        /// <summary>
        /// Сериализует обьект в заданный файл.
        /// </summary>
        public static void Serialize(object obj, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                new BinaryFormatter().Serialize(fs, obj);
        }

        /// <summary>
        /// Возвращает десериализованный обьект из файла.
        /// </summary>
        public static object Deserialize(string path)
        {
            try
            {
                object obj = null;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    obj = new BinaryFormatter().Deserialize(fs);
                return obj;
            }
            catch { return null; }
        }

        /// <summary>
        /// Удаляет заданный аккаунт.
        /// </summary>
        public static void RemoveAccount(Account account)
        {
            if (AccountExists((acc) => acc.Name == account.Name))
            {
                var accounts = LoadAccounts();
                accounts.Remove(accounts.Find((acc) => acc.Name == account.Name));
                Serialize(accounts, AccountsFileName);
            }
            else
                throw new Exception("account haven`t been founded to remove it");
        }

        /// <summary>
        /// Проверяет, существует ли аккаунт с заданным фильтром?
        /// </summary>
        public static bool AccountExists(Predicate<Account> match)
        {
            return LoadAccounts().Find(match) != null;
        }

        /// <summary>
        /// Возвращает десериализованный объект типа Account с заданным фильтром.
        /// </summary>
        /// <param name="name">Имя аккаунта, которого вернёт метод</param>
        public static Account GetAccount(Predicate<Account> match)
        {
            return LoadAccounts().Find(match);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void UpdateAccount(string oldAccountName, Account targetAccount)
        {
            var accounts = LoadAccounts();
            if (AccountExists((acc) => acc.Name == oldAccountName))
            {
                RemoveAccount(GetAccount((acc) => acc.Name == oldAccountName));
                SaveAccount(targetAccount);
            }
            else
                throw new Exception("account haven`t been founded to update it");
        }

        /// <summary>
        /// Проверяет пароль пользователя на правильность написания: допускаються только русские и английские символы, цифры и подчеркивания.
        /// </summary>
        public static bool PasswordIsCorrect(string pass, out string message)
        {
            if (pass.Length < 5)
            {
                message = "Строка слишком короткая";
                return false;
            }
            foreach (var ch in pass)
                if (!@"ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮqwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789_-".Contains(ch.ToString()))
                {
                    message = @"Строка может содержать только русские и английские символы, а также цифры 0-9 и подчёркивания";
                    return false;
                }
            message = null;
            return true;
        }

        /// <summary>
        /// Проверяет имя пользователя на правильность написания: допускаються только русские и английские символы, цифры и подчеркивания.
        /// </summary>
        public static bool NameIsCorrect(string name, out string message)
        {
            if (!PasswordIsCorrect(name, out string mes))
            {
                message = mes;
                return false;
            }
            if (AccountExists((acc) => acc.Name == name))
            {
                message = "Аккаунт с таким именем уже существует";
                return false;
            }
            message = null;
            return true;
        }

    }
}
