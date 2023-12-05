using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Storing_Teachers_record
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClassSection { get; set; }
        
        public void AddRecord()
        {
            StreamWriter sw;
            string fpath = "C:\\Users\\Samiksha\\OneDrive\\Desktop\\GitAssignment\\Phase 1\\Assessment Project2\\TeacherData.txt";
                Console.WriteLine("Enter the ID of the teacher");
                ID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enterthe Name of the teacher");
                Name = Console.ReadLine();

                Console.WriteLine("Enter the Class and Section");
                ClassSection = Console.ReadLine();
           
            
            
                
        }
       
        public void Display()
        {

            StreamReader sr;

            try
            {
                string fpath = "C:\\Users\\Samiksha\\OneDrive\\Desktop\\GitAssignment\\Phase 1\\Assessment Project2\\TeacherData.txt";
                sr = new StreamReader(fpath);
                string text = " ";
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.Write("");
            }
            
        }
    }
}
