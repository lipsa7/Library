using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryICT
{
    public class BookBO
    {
        public List<string> FindBook(List<string> bookList, string authorName)
        {
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < bookList.Count; i++)
            {
                list2.Add(bookList[i].Split(','));
            }

            List<string> list4 = new List<string>();
            //string[] array=new string[6];
            for(int i = 0; i < list2.Count(); i++)
            {
                if (list2[i][1]==authorName)
                {
                    foreach(var item in list2[i])
                    {
                        list4.Add(item);
                    }
                    //array = list2[i];
                }
                //else
                //{
                //    Console.WriteLine("No such book is present");
                //}
            }

            //List<string> list3 = array.ToList();
            return list4;
        }

        public List<string> FindBook(List<string> bookList, double rating)
        {
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < bookList.Count; i++)
            {
                list2.Add(bookList[i].Split(','));
            }

            List<string> list4 = new List<string>();
            //string[] array = new string[6];
            for (int i = 0; i < list2.Count(); i++)
            {
                if (Convert.ToDouble(list2[i][5])==rating)
                {
                    foreach (var item in list2[i])
                    {
                        list4.Add(item);
                    }
                }
                //else
                //{
                //    Console.WriteLine("No such book is present");
                //}
            }

            //List<string> list3 = array.ToList();
            return list4;
        }
    }
}
