﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class BIN_file<T> where T: Item
    {
        BinaryFormatter formatter = new BinaryFormatter();
        public void WriteFile(List<T> example_gen, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    formatter.Serialize(fs, example_gen);
                }
            }
            catch
            {
                return;
            }
        } 

        public List<T> ReadFile(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    if (fs.Length != 0)
                    {
                        List<T> deserilizeList = new List<T>(); 
                        deserilizeList = (List<T>)formatter.Deserialize(fs);
                        return deserilizeList;
                    }
                }
                catch
                {
                    return null;
                }
                return null;
            }
        }
    }



    class Read_from_file
    {
        public void ReadFile()
        {
            string readPath = @"C:\C#_dir\1.txt";
            using (StreamReader r = new(readPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    if (line.Contains("Food"))
                    {
                        Food temp = new();
                        // temp.Name = Convert.ToString(line.TakeWhile((symbol_letter)=>Char.IsLetter(symbol_letter)));
                        //int j = 0;
                        //for (int i = 4; i < line.Length; i++)
                        //{
                        //    if (Char.IsLetter(line[i]))
                        //    {                           
                        //        for (j = i; !Char.IsWhiteSpace(line[j]); j++)
                        //        {

                        //        }
                        //        temp.Name = line.Substring(i, j - i);
                        //        i = j;

                        //    }
                        //    if (Char.IsDigit(line[i]) && j != 0)
                        //    {
                        //        j = 0;
                        //        for (j = i; j < line.Length; j++)
                        //        {

                        //        }
                        //        temp.Expiration_date = Convert.ToDateTime(line.Substring(i, j - i));
                        //        i = j;
                        //    }
                        //}
                        var onlyLetters = new String(line.Substring(5, line.Length - 5).Where(Char.IsLetter).ToArray());
                        var onlyDateTime = new String(line.Substring(10, line.Length - 10).Where(c => Char.IsDigit(c) || c == '/').ToArray());
                        temp.Name = onlyLetters;
                        temp.Expiration_date = Convert.ToDateTime(onlyDateTime);
                        Date.Property_for_warehouse.list_of_food.Add(temp);

                    }
                    if (line.Contains("Materials"))
                    {
                        Materials temp = new();
                        Date.Property_for_warehouse_materials.list_of_materials.Add(temp);
                    }
                }
            }
        }


    }

}
   
 
   

