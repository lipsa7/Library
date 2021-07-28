using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryICT
{
    public class Book:IComparer<string>
    {
        private string _name;
        private string _authorName;
        private string _type;
        private string _catalogNo;
        private DateTime _publishedDate;
        private double _rating;
        //private string _input;

        //default and parameterized

        public Book()
        {

        }

        //public string Name { get => _name; set => _name = value; }
        //public string AuthorName { get => _authorName; set => _authorName = value; }
        //public string Type { get => _type; set => _type = value; }
        //public string CatalogNo { get => _catalogNo; set => _catalogNo = value; }
        //public DateTime PublishedDate { get => _publishedDate; set => _publishedDate = value; }
        //public double Rating { get => _rating; set => _rating = value; }
        public string Name;
        public string AuthorName;
        public string Type;
        public string CatalogNo;
        public DateTime PublishedDate;
        public double Rating;
        //public string Input { get => _input; set => _input = value; }
        public Book(string _name, string _authorName, string _type, string _catalogNo, DateTime _publishedDate, double _rating)
        {
            Name = _name;
            AuthorName = _authorName;
            Type = _type;
            CatalogNo = _catalogNo;
            PublishedDate = _publishedDate;
            Rating = _rating;
        }

        public override string ToString()
        {
            return "Name: "+Name+" Author: "+AuthorName+" Type: "+Type+" CatalogNo: "+CatalogNo+" Published Date: "+PublishedDate+" Rating: "+Rating;
        }

        public static Book CreateBook(String detail)
        {
            Book b=new Book();
            Library lib = new Library();
            string[] bookArray = detail.Split(',');
            b.Name = bookArray[0];
            b.AuthorName = bookArray[1];
            b.Type = bookArray[2];
            b.CatalogNo = bookArray[3];
            b.PublishedDate = Convert.ToDateTime(bookArray[4]);
            b.Rating = Convert.ToDouble(bookArray[5]);
            return b;
            //lib.BookList.Add(b.Name);
            //BookDetails.Add("Author Name: " + b.AuthorName);
            //BookDetails.Add("Type: " + b.Type);
            //BookDetails.Add("Catalog No: " + b.CatalogNo);
            //BookDetails.Add("Published Date: " + b.PublishedDate);
            //BookDetails.Add("Rating: " + Math.Round(b.Rating, 1));
        }

        public int Compare(string x, string y)
        {
            //this = new Book();
            //other = new Book();
            //return Name.CompareTo(other.Name);
            return x.CompareTo(y);
        }
        public static SortedDictionary<string, int> TypeWiseCount(List<string> list)
        {
            List<string[]> list2 = new List<string[]>();
            for(int i=0;i<list.Count;i++)
            {
                list2.Add(list[i].Split(','));
            }

            List<string> list3 = new List<string>();

            for(int i = 0; i < list2.Count; i++)
            {
                list3.Add(list2[i][2]);
            }

            //List<string> list4 = list3.Distinct().ToList();

            string[] list3Array = list3.ToArray();

            var groups = list3Array.GroupBy(z => z);

            //foreach(var group in groups)
                

            SortedDictionary<string, int> Book_dict2 = new SortedDictionary<string, int>();

            foreach (var group in groups)
            {
                Book_dict2.Add(group.Key, group.Count());
            }

            
            return Book_dict2;
        }
    }



       
        

}

