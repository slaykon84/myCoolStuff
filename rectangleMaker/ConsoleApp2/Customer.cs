using System;
using System.Collections.Generic;
using System.Text;

namespace Console1
{
   
    public class CustomerInformation
    {
        public int Id;
        public int joinYear;
        public CustomerInformation(int id , int joinyear)
        {
            Id = id;
            joinYear = joinyear;
        }
        
        public string firstName { get;  set; }
        public string lastName { get; set; }
        public int location { get; set; }
    }
}

