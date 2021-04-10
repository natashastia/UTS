using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace GradeBook    
{    
    //Base Class    
    public class Books    
    {    
        public void BooksMethod()    
        {    
            Console.WriteLine("this property belong to Books");    
        }    
    }    
     
    //Derived class    
    public class Novel : Books    
    {    
        public void NovelMethod()    
        {    
            Console.WriteLine("this property belong to Novel");    
        }    
    } 
    public class Magazine : Books    
    {    
        public void MagazineMethod()    
        {    
            Console.WriteLine("this property belong to Magazine");    
        }    
    } 
}