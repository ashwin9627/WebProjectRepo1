using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject1.Models;

namespace WebProject1.Controllers
{
    public class HomeController : Controller
    {
        int a = 0;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateList()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateList(Table3 t12)
        {
            FirstDBEntities1 obj1 = new FirstDBEntities1();
            Table3 t1 = new Table3();
            t1.Register_no = t12.Register_no;
            t1.custname = t12.custname;
            t1.Phone_no = t12.Phone_no;
            obj1.Table3.Add(t1);
            //db.crud.InsertOnSubmit(data1); 
            if (t12.Register_no == t1.Register_no)
            {
                ViewBag.ang = "register number is already taken, please give some other number";
            }
                obj1.SaveChanges();
            
  //if(t12.Register_no==0 && t12.custname==null && t12.Phone_no==null )
  //          {
  //              ViewBag.Error = "Please Dont keep the textbox empty and dont use null values";
  //          }
  //          //var ing= obj1.SaveChanges();
         
            namelist nameobj = new namelist();
            nameobj.firstName = "Ashwin";
            nameobj.lastName = "kumar";
            ViewBag.name1=nameobj.firstName + nameobj.lastName;
            return View();
        }
        public ActionResult Contact()
        {
            
            FileTest();
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public void FileTest()
        {
            FileStream f = new FileStream("E:\\DummyText4.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            StreamWriter sw = new StreamWriter(f);

            sw.WriteLine("This is the testing for the file");
            var line = s.ReadToEnd();
            var lb = line.ToString();
            ViewBag.T1 = lb;
            sw.Close();
            s.Close();
            f.Close();
        }
        public ActionResult Student()
        {
            student s1 = new student();
            studentinfo s2 = new studentinfo();
            studentinfo.Stu();
            s1.name = "";
            s1.phone_Number = 9877483938;
            s1.Register_Number = 12345;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Table3 T1)
        {
            //FirstDBEntities1 db = new FirstDBEntities1();
            //Table3 T2 = new Table3();
            //if (T2.Register_no == T1.Register_no && T2.custname == T1.custname)
            //{
            //    return View("Index");
            //}
           return View();                 
        }
        public ActionResult Num321()
        {
             a = 10;
            int b = 30;
            int c=50;
            int E=0;
            //  NumberClass num2 = new NumberClass();
            numberfield1 num67 = new numberfield1();
            num67.num(a);
            ViewBag.test =inttest();
            return View();
        }           
     
        public void name(Table3 tab1)
        {
            namelist n1 = new namelist();
            Table3 t1 = new Table3();
            t1.Register_no = 100;
            t1.Phone_no = 12345;
            if(tab1.Register_no==t1.Register_no)
            {
                inttest();
            }           
        }
        
        public int inttest()
        {
            int a = 10;
        //    int b = 5;
            return a=a+a ;
        }
        public class numberfield1
        {
            public void num(int c)
            {
                c = c + c;
            }
        }
    }
}