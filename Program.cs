using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LINQ_to_objects2
{
    class Program
    {
        static void Main()
        {
            // using lambda
            //make list to store countries
            List<string> country = new List<string>();
            //add country
            country.Add("india");
            country.Add("australia");

            //using lambda to show list of countries
            //lambda is to set parameter from left to right .In right we perform operations
            IEnumerable<string> res = country.Select(x => x);

            //loop to access countries
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //-------------------------------------
            //Min() - use to get min value from list
            int[] ar = { 1, 2, 3, 4, 5 };
            int m = ar.Min();
            Console.WriteLine(m);
            Console.ReadLine();

            /*output = 1*/
            //-----------------------------
            //max 
            int[] arr = { 1, 2, 3, 4, 5 };
            int ma = ar.Max();
            Console.WriteLine(ma);
            Console.ReadLine();
            /*output = 1*/
            //--------------------------------
            //sum
            int po = ar.Sum();
            Console.WriteLine(po);
            Console.ReadLine();
            /*output = 15*/

            //--------------------------------
            //count =to  count number of elements
            int Count = ar.Count();
            Console.WriteLine(Count);
            Console.ReadLine();
            /*output = 5*/

            //------------------------------------
            //Aggregate()- is used to perform operations on each item in list
            int[] n = { 1, 2, 3, 4 };
            int A = n.Aggregate((a, b) => a + b);
            Console.WriteLine("{0}", A);
            Console.ReadLine();

            //------------------------------------
            //partition operator
            //is used to partititon list into2 parts and return 1 part of list items 
            //operators used = TAKE,TAKEWHILE,SKIP,SKIPWHILE

            //TAKE=to return number of elements in sequence
            // TAKEWHILE=to return number of elements in sequence which satisfy condition
            //SKIP = to return number of elements in sequence  and return remaining elemnst
            //SKIPWHILE = to return number of elements in sequence which satisfy condition as true


            //TAKE
            //create array of countries 
            string[] countri = { "india", "japan", "australia", "germany" };


            //use take method, it will return value of string upto assigned numbers
            IEnumerable<string> result = (from x in countri select x).Take(3);

            //access them
            foreach (string co in result)
            {
                Console.WriteLine(co);

            }
            Console.ReadLine();
            /*output = india", "japan", "australia" */
            //------------------------------------------------------

            //Takewhile
            //query
            IEnumerable<string> resul = (from x in countri select x).TakeWhile(x => x.StartsWith("i"));

            //access them
            foreach (string cos in resul)
            {
                Console.WriteLine(cos);

            }
            Console.ReadLine();
            /*output - india*/
            //------------------------------------
            //skip
            IEnumerable<string> resu = (from x in countri select x).Skip(3);

            //access them
            foreach (string co in resu)
            {
                Console.WriteLine(co);

            }
            Console.ReadLine();
            /*output =germany*/
            //------------------------------------
            //ToList()- takes element from source and returns list
            //using query
            List<string> re = (from x in countri select x).ToList();


            //access them
            foreach (string co in re)
            {
                Console.WriteLine(co);

            }
            Console.ReadLine();

            /*output = india
japan
australia
germany
*/
            //------------------------------------

            //ToArray()-is used to convert input elements in collection of array
            //query
            string[] r = (from x in countri select x).ToArray();
            //access them
            foreach (string co in r)
            {
                Console.WriteLine(co);

            }
            Console.ReadLine();
            /*output =  india
japan
australia
germany
*/
            //------------------------------------

            //cast()
            //is used to convert all elements present in collection to specified data  type of new collection
            //syntax - IEnumerable<string> result = obj.Cast<string>();  

            //import using System.Collections;
            //create object for arraylist

            ArrayList oblist = new ArrayList();


            //add values to object
            oblist.Add("pune");
            oblist.Add("mumbai");
            oblist.Add("indore");

            //now covert arraylist object to string type of object
            IEnumerable<string> ress = oblist.Cast<string>();
            //access thrm now
            foreach (var i in ress)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            /*output =mumbai
             pune
            indore */
            //------------------------------------
            //OfType()
            //is used to return element of specific type and another element will be ignored from list/collection

            //syntax = IEnumerable<string> result = obj.OfType<string>();  

            //create arraylist and add objects (used above)
            IEnumerable red = oblist.OfType<string>();

            //access thrm now
            foreach (var i in red)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            /*output =mumbai
          pune
         indore */
            //------------------------------------
            //AsEnumerable
            //is used to convert list to enumerable

            //first create array of int type
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };

            //appliying AsEnumerable to store in variable
            var result1 = array1.AsEnumerable();


            //access them
            foreach (var x in result1)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
            /*output = 1
2
3
4
5
6 */

            //---------------------------------------------------
            //ToDictionary()
            //is used to convert list/collections to dictionary

            //use class Student made (below)

            //create object of student class and add info of student in list
            List<Student> obs = new List<Student>()
            {
                new Student() { name = "ritika", gender = "female"},
                new Student() { name = "pallav", gender = "male"},


            };

            //now converting the collection in form of dictionary
            var s = obs.ToDictionary(x => x.name, x => x.gender);

            //access them
            foreach (var x in s)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

            /*output = [ritika, female]
[pallav, male]
*/

            //----------------------------------------
            //element operators in LINQ
            //First       
            //firstOrDefault
            //Last
            //LastElementAt
            //ElementAt
            //ElementAtOrDefault
            //single
            //singleordefault
            //DefaultEmpty


            //First()
            //is used to return first element from list/collection

            //createarraylist of int type
            int[] objlist = { 20, 30, 40, 50 };

            int result2 = (from i in objlist select i).First();         //query 
            Console.WriteLine(result2);
            Console.ReadLine();
            /*output = 20*/


            //---------------------------------------------
            //FirstOrDefault
            //it returns first element from list ,and if it returns no element ,it will return a default value

            //make 2 arrays of int type
            int[] olist3 = { 56, 54, 58, 59, 52 };
            int[] olist4 = { };

            //use FirstOrDefault
            int res5 = (from i in olist3 select i).FirstOrDefault();       //query
            int res6 = (from j in olist4 select j).FirstOrDefault();        //query

            //print them
            Console.WriteLine(res5);
            Console.WriteLine(res6);

            Console.ReadLine();
            /*output = 56
                               0*/
            //--------------------------------------------
            //Last()
            //will return last item

            //--------------------
            //LastDefault()
            int res7 = (from i in olist3 select i).LastOrDefault();       //query
            int res8 = (from j in olist4 select j).LastOrDefault();        //query

            //print them
            Console.WriteLine(res7);
            Console.WriteLine(res8);

            Console.ReadLine();
            /*output =    /*output = 56
                               0*/

            //-----------------------------------------------
            //ElementAt()
            //is used to return elements on specific index

            //using olist3(upwards)
            int res9 = olist3.ElementAt(2);
            Console.WriteLine(res9);
            Console.ReadLine();
            //output = 58
            //---------------------------------------------------

            //single
            //is used to return single element from collection which satiefies condition


            List<Student> obstd = new List<Student>()
            {
                new Student() { name = "ritika", gender = "female"},
                new Student() { name = "pallav", gender = "male"},


            };

            //initialize array 
            int[] oblists = { 1 };        //only 1 element it should have for single

            var u = obstd.Single(se => se.name == "ritika");
            string res11 = u.name;
            int var2 = oblists.Single();

            Console.WriteLine(res11);
            Console.WriteLine(var2);
            Console.ReadLine();

            /*output = ritika
                               1*/

            //-------------------------------------
            //singleOrDefault
            //is used to return single element having  more than 1 info

            int[] oblisted = { 1, 2, 3, 4, 5 };

            var user = obstd.SingleOrDefault(i => i.name == "pallav");
            string resulr = user.name;

            int w = oblisted.SingleOrDefault(j => j > 5);

            Console.WriteLine(w);
            Console.WriteLine(resulr);
            Console.ReadLine();
            /*output = 0
pallav
*/
            //---------------------------------------------

            //GroupBy
            //is used to groupin the list/collection items based on the specified value of the key,
            //and it returns a collection of IGrouping<key, Values>. 


            //using student class made below


            //create list object 
            List<Student> obslists = new List<Student>()
            {
                new Student() { name = "piyali", gender = "female"},
                 new Student() { name = "sonam", gender = "male" },
            };


            //using groupby
            var s1 = from std in obslists group std by std.name;            //query

            //access them
            foreach (var i in s1)
            {
                Console.Write(i.Key, i.Count());     //count number of students
                Console.WriteLine();

                foreach (var j in i)
                {
                    Console.WriteLine(j.name, j.gender);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            /*output = piyali
piyali
sonam
sonam     */

            //-----------------------------------------------




            //orderby

            //syntax for descending order - var studentname = Objstudent.OrderByDescending(x => x.Name);  
            //make 1 lst of students

            //Student class made below with properties
            List<Student> ob = new List<Student>()
         {
             new Student(){ name = "payal", gender = "female"},
               new Student(){ name = "sakshi", gender = "female"},
         };
            var sname = ob.OrderBy(x => x.name);
            foreach (var i in sname)
            {
                Console.WriteLine(i.name);   //getting names stored in temporary variable
            }
            Console.ReadLine();
            /*output = payal
             sakshi*/

            //------------------------------------
            //orderbyDescending


            //Student class made below with properties
            List<Student> obj = new List<Student>()
            {
                new Student(){ name = "payal", gender = "female"},
                  new Student(){ name = "sakshi", gender = "female"},
            };
            var snames = obj.OrderByDescending(x => x.name);
            foreach (var i in snames)
            {
                Console.WriteLine(i.name);   //getting names stored in temporary variable
            }
            Console.ReadLine();
            /*output =
           sakshi
            payal */


            //------------------------------------
            //ThenBy() = will sort in ascending order

            //Student class made below with properties
            List<Student> obt = new List<Student>()
            {
                new Student(){ name = "payal", gender = "female"},
                  new Student(){ name = "sakshi", gender = "female"},
            };
            var sgendername = obt.OrderBy(x => x.name).ThenBy(x => x.gender);
            foreach (var i in sgendername)
            {
                Console.WriteLine("{0} and {1}", i.name, i.gender);   //getting names stored in temporary variable
            }
            Console.ReadLine();
            /*output = payal and female
                         sakshi and female*/
        }
    }

    class Student
    {
        public string name { get; set; }
        public string gender { get; set; }



    }

}

       