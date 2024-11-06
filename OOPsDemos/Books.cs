using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemos
{


    public abstract class Books
    {
        public string BookName { get; set; }
        public float Price { get; set; }
        public int AuthorID { get; set; }

        public abstract string BookType { get; set; }
    }

    public class Fiction : Books
    {
        private string _bookType;
        public override string BookType
        {
            get
            {
                return _bookType;
            }
            set
            {
                _bookType = value;
            }

        }
    }


    public class Novels : Books
    {
        //overriding means base class functionality needs to be
        //overriden by the child class so that the child class can make it behave 
        //as per its requirement
        private string _bookType;
        public override string BookType
        {
            get
            {
                return _bookType;
            }
            set
            {
                _bookType = value;
            }

        }
    }

}