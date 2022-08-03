using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public static class UsersResultStorage
    {
        public static string FileName = "Results_of_Testing.json";

        
        public static void Append(User user)
        {
            var userResults = GetUserResults();
            userResults.Add(user);
            Save(userResults);
        }


        public static List<User> GetUserResults()
        {
            if (!FileProvider.Exists(FileName))
            {
                return new List<User>();
            }

            var fileData = FileProvider.Get(FileName);
            var results = JsonConvert.DeserializeObject<List<User>>(fileData);
            return results;
        }

        public static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Write(FileName, jsonData);
        }
    }
        

}








