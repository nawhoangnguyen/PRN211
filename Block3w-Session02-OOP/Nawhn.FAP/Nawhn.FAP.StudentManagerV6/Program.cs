using System.Xml.Linq;

namespace Nawhn.FAP.StudentManagerV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student("SE121212", "Naw", 7.9);
            //Student s2 = new Student("SE121213", "CR7", 7.9);
            //Student s3 = new Student("SE121214", "M10", 7.9);
            //muốn lưu được nhiều sv hơn, ds 30 sv, ta phải khai báo 30 biến lẻ
            //s3 s4 s5 sau đó = new Student(....) cho từng biến
            //KHAI BÁO BIẾN VÀ GẮN VALUE - MỆNH ĐỀ 2 VIỆC

            //muốn lưu 30 sv gau bái biến hiệu quả hơn:
            //ta dùng mảng - CHỈ LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN, GÁN BIẾN THÌ 
            //TRUYỀN THỐNG = NEW STUDENT(...)
            Student[] s = new Student[6]; //CHỈ LÀ 30 BIẾN THOI HENG
            //CHƯA CÓ SV CỤ THỂ NÀO, VÌ MÚN CÓ SV CỤ THỂ THÌ PHẢI NEW STUDENT(NGOẶC TRÒN)
            s[0] = new Student()
            {
                Id = "SE10",
                Gpa = 7.9,
                Name = "An Nguyen",
                Yob = 2002
            };
            s[1] = new Student()
            {
                Id = "SE11",
                Gpa = 7.6,
                Name = "Messi Nguyen",
                Yob = 2003
            };
            s[2] = new Student()
            {
                Id = "SE12",
                Gpa = 7.2,
                Name = "Ronaldo Nguyen",
                Yob = 2008
            };
            s[3] = new Student()
            {
                Id = "SE13",
                Gpa = 8.0,
                Name = "Ronaldinho Nguyen",
                Yob = 2000
            };
            s[4] = new Student()
            {
                Id = "SE14",
                Gpa = 7.7,
                Name = "Kaka Nguyen",
                Yob = 2007
            };
            s[5] = new Student()
            {
                Id = "SE15",
                Gpa = 6.8,
                Name = "Benzema Nguyen",
                Yob = 2006
            };





            //s[6] = s[5] = new Student()
            //{
            //    Id = "SE15",
            //    Gpa = 6.8,
            //    Name = "Benzema Nguyen"
            //}; //2 biến cùng trỏ 1 vùng new, 2 biến 5 6 cùng là 1 dũng đặng
            // dánh sách sv bị trùng bạn nào đó, thấy 2 dòng tên, chỉ là 1 đứa
            //CHỨNG MINH:
            //s[6]
            //s[6].Name = "Modric Nguyen";
            //s[7] = s1; //bạn có mã số Se121212 lcs này có 2 trỏ cùng 1 chỗ
            //Console.WriteLine(s[0]);
            //Console.WriteLine(s[1]);
            //Console.WriteLine(s[2]);
            //Console.WriteLine(s[3]);


            Console.WriteLine("==============- Insertion sort -==============");
            Console.WriteLine("=> Ascending by Yob <=");
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Yob > s[j].Yob)
                    {
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }
                }

            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=> Descending by Yob <=");
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Yob > s[j].Yob)
                    {
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }
                }

            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=> Ascending by Id <=");
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (Int32.Parse(s[i].Id.Split("SE")[1]) > Int32.Parse(s[j].Id.Split("SE")[1]))
                    {
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }
                }

            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=> Descending by Id <=");
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (Int32.Parse(s[i].Id.Split("SE")[1]) < Int32.Parse(s[j].Id.Split("SE")[1]))
                    {
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }
                }

            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============- Bubble sort -==============");
            Console.WriteLine("=> Descending by Id <=");

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1 ; j < s.Length; j++)
                {
                    if (s[i].Yob < s[j].Yob)
                    {   
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1 ; j < s.Length; j++)
                {
                    if (s[i].Yob < s[j].Yob)
                    {   
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=> Ascending by Id <=");

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Yob > s[j].Yob)
                    {
                        var temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }









        //static void Main(string[] args)
        //{
        //    var s = new Student("SE170710", 7.9);
        //    //name argument: chỉ ra tên tham số hàm cho rõ
        //    Console.WriteLine(s.Name + " | " + s.Gpa);
        //}
    }
}