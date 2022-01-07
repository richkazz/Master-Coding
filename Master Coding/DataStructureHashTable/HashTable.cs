using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.DataStructureHashTable
{
    public class HashTable
    {
        dynamic[] data;
        int hachCode = 0;
        public HashTable(int size)
        {
            data = new dynamic[size];
        }
        private int Hash(string key)
        {
            var hash = 0;
            for (var i = 0; i < key.Length; i++)
            {
                hash = (hash + key.ToCharArray()[i] * i) % data.Length;
            }
            return hash;
        }
        private dynamic checkExistGet(string key)
        {
            hachCode = Hash(key);
            var value = data[hachCode];
            
            if(value == null)
            {
                return "Error: dose not exist";
            }
            else
            {
                foreach(var item in value)
                {
                    var x = item as Tuple<string, dynamic>;
                    if(key== x.Item1)
                    {
                        return x.Item2;
                    }

                }
                return "Error: dose not exist";
            }
           
        }
        private bool checkExistSet(string key)
        {
            var value = data[Hash(key)];
            if(value == null)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }

        public dynamic Get(string key) => checkExistGet(key);
        public void Set(string key, dynamic value)
        {
            hachCode = Hash(key); 
            if (checkExistSet(key))
            {
                AddDataIfExitBefore(key, value);
               
            }
            else
            {
                AddDataIfNotExitBefore(key, value);
            }
        }

        private void AddDataIfExitBefore(string key, dynamic value)
        {
            var dataAtHashCode = data[hachCode] as List<dynamic>;
            for (var i =0;i< dataAtHashCode.Count; i++)
            {
                var x = dataAtHashCode[i] as Tuple<string, dynamic>;
                if (key == x.Item1)
                {
                    dataAtHashCode[i] = new Tuple<string, dynamic>(key, value);
                    return;
                }

            }
            dataAtHashCode.Add(new Tuple<string, dynamic>(key, value));
            data[hachCode] = dataAtHashCode;
        }
        private void AddDataIfNotExitBefore(string key, dynamic value)
        {
            var newData = new List<dynamic>();
            newData.Add(new Tuple<string, dynamic>(key, value));
            
            data[hachCode] = newData;
        }

        public List<string> Keys() => LoopDataGetKeys();
        private List<string> LoopDataGetKeys()
        {
            List<dynamic> keysList = new List<dynamic>();
            foreach(var item in data)
            {
                if(!isNull(item))
                {
                    keysList.Add(item);
                }
            }

            return new List<string>();
        }
        private bool isNull(dynamic dynamic) => dynamic == null;
        
    }
}
