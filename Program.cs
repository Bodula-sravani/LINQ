namespace LINQ
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int age { get; set; }

        //public class IEqualityComparer:IEqualityComparer<Student>

        //{
        //    bool IEqualityComparer<Student>.Equals(Student? x, Student? y)
        //    {

        //    }
        //}
       

    }


    public class employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string dept { get; set; }
    }
        internal class Program
        {
            static void Main(string[] args)
            {

            //List<string> list = new List<string>() { "sravani", "latha", "ram", "aish", "shu", "dinn" };

            //var query = from name in list select name;

            //var query1 = list.ToList();

            //List<string> list2 = new List<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    list2.Add(list[i]);
            //}


            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> nums = new List<int>() { 1, 3, 2, 4, 5, 7, 2, 1, 6 };

            //nums.Take(5).ToList().ForEach(x => { Console.WriteLine(x); });

                List<Student> students1 = new List<Student>() {
                 new Student() { Id=1,Name="student1",age=21},
                 new Student() { Id = 2, Name = "student2",age=23 },
                 new Student() { Id = 3, Name = "student3",age=19 },
                 new Student() { Id = 4, Name = "student2",age=20 },
                 new Student() { Id = 5, Name = "2student3",age=19 },
                 new Student() { Id = 6, Name = "2student2",age=20 }
               };

            List<Student> students2 = new List<Student>() {
                 new Student() { Id=1,Name="student1",age=21},
                 new Student() { Id = 2, Name = "student2",age=23 },
                 new Student() { Id = 5, Name = "2student3",age=19 },
                 new Student() { Id = 6, Name = "2student2",age=20 }
            };

            students1.Take(4).Where(x=> x.age>20).ToList().ForEach(x => { Console.WriteLine(x.Name); });

            //students1.Select(x => x.Id).Except(students2.Select(x => x.Id)).ToList().ForEach(x => { Console.WriteLine(x); });
            //students1.Select(x => x.Id).Intersect(students2.Select(x => x.Id)).ToList().ForEach(x => { Console.WriteLine(x); });
            //students2.UnionBy(students1,x=>x.Name).ToList().ForEach(x=> { Console.WriteLine(x.Name); });
            //students1.Select(x => x).Union(students2.Select(x => x)).ToList().ForEach(x => { Console.WriteLine(x.Id+" "+x.Name); });

            // students.Select(x => x.Name).Distinct().ToList().ForEach(x => { Console.WriteLine(x); });

            // students.DistinctBy(x => x.Name.Length).Select(x => x.Name).ToList().ForEach(x => { Console.WriteLine(x); });



            //bool studentFlag = students.Contains(students.Wherx=>e(student => student.age == 20).Select(student=>student).Single());
            //  Console.WriteLine(studentFlag);


            // var query3 = from student in students where (student.Id > 1) select student;

            //foreach(var s in query3)
            //{
            //    Console.WriteLine(s.Name);
            //}

            //var Query4 = students.Where(x => x.Id > 1).Select(x => x.Name);

            //foreach (var s in Query4)
            //{
            //    Console.WriteLine(s);
            //}

            List<int> numbers1 = new List<int>() { 12, 341, 134, 13, 1, 41, 13, 1, 133, 1, 46, 5, 42 };
                List<int> numbers2 = new List<int>() { 123, 6, 4, 3, 8, 10, 9, 43, 2, 3, 5, 5, 5, 5, 5 };
                List<List<int>> numList = new List<List<int>>();
                numList.Add(numbers1);
                numList.Add(numbers2);

                //var result = numList.SelectMany(list => list.FindAll(x => x > 100));


                //var resultDistinct = numList.SelectMany(list => list).Distinct();
                //foreach(var i in result)
                //{
                //    Console.WriteLine(i);
                //}

                List<employee> listEmp = new List<employee>()
                {
                    new employee() {Id = 1,Name="emp1",dept="test"},
                    new employee() {Id = 2,Name="emp2",dept="dev"},
                    new employee() {Id = 3,Name="emp3",dept="dev"},
                    new employee() {Id = 1,Name="emp4",dept="test"},
                    new employee() {Id = 1,Name="emp5",dept="support"},
                    new employee() {Id = 6,Name="emp6",dept="test"},
                    new employee() {Id = 2,Name="emp7",dept="support"}
                };

                var empResult = listEmp.Where(emp =>
                {
                    return emp.Id > 2 && emp.dept == "test";
                }
                ).ToList();

            //foreach (var item in empResult)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //List<object> listObj = new List<object>() { 1,2.3,4,"error",10,"happy",'a',"bat",'b'};

            //var resObj = listObj.OfType<char>().ToList();  //method way

            //var objQuery = (from a in listObj where a is string orderby a select a).ToList(); //query way 

            //var objQuery = (from a in listObj where a is string select a).ToList().OrderByDescending(a=>a);
            
            

            //List<string> steList = new List<string>() { "oe", "two", "three", "four", "five" };
            //var objQuery = (from a in listObj where a is string orderby a select a).ToList(); //query way 

            //var objQuery = (from a in steList select a).ToList().OrderByDescending(a => a);
            //foreach (var item in objQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //listEmp.OrderBy(e => e.Id).ThenBy(e=>e.dept).ToList().ForEach(x => { Console.WriteLine(x.Name); });

            //List<List<int>> mat2 = new List<List<int>>() { new List<int> { 1, 2, 2 },
            //                                                new List<int> { 1, 2, 4 },
            //                                                new List<int> { 2, 4, 4 }

            //};

            //mat2.OrderBy(mat2 => mat2[0]).OrderByDescending(mat2 => mat2[1]).ToList().
            //    ForEach(x =>
            //    {
            //        Console.WriteLine(string.Join(",", x));
            //    });

            //mat2.OrderBy(mat2 => mat2[0]).ThenBy(mat2 => -mat2[1]).ThenByDescending(mat2 => mat2[2]).ToList().
            //    ForEach(x => {
            //        Console.WriteLine(string.Join(",", x));
            //    });

            //List<int> reverseList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };


            //List<object> objList = new List<object>() { 1, "sra", 2, "b", 3, 6, "last" };

            //objList.Reverse();
            //reverseList.Reverse();

            //foreach(var obj in objList)
            //{
            //    Console.WriteLine(obj);
            //}

            //bool condidtion = objList.Any(x => x.Equals("sra"));
            //Console.WriteLine(condidtion);
             
            //foreach(var obj in reverseList.FindAll(x=>x>1))
            //{
            //    Console.WriteLine(obj);
            //}
        }
   }

}