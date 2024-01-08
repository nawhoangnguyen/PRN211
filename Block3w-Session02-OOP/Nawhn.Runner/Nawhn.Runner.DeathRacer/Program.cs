namespace Nawhn.Runner.DeathRacer
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Drone d1 = new Drone() { Name = "GTR-34", Model = "Nismo", Manufacturer = "Nissan" };
        //    Racer d2 = new Drone() { Name = "Civic", Model = "Type R", Manufacturer = "Honda" };
        //    //câu hỏi đặt ra d1 . xổ ra gì d2 . xổ ra gì
        //    Drone d3 = (Drone)d2;
        //    //kéo con trỏ 
        //    //sợi dây thun
        //    Console.WriteLine(d3.Name);

        //    //kĩ thuật tuyệt đỉnh kungfu ko cần biến drone lẻ chơi trực tiếp
        //    Console.WriteLine("Kĩ thuat Kung-fu Panda " + ((Drone)d2).Name);
        //    Console.WriteLine("In full d2 theo style tuyet dinh Kung-fu Panda | Name: " + ((Drone)d2).Name + " | Model: " +((Drone)d2).Model + " | Manufacturer: " + ((Drone)d2).Manufacturer);
        //    //chỉ chơi ép con trỏ khi khai cha new con nhưng lại muốn xài hàm của con
        //}
        static void Main(string[] args)
        {
            Student s = new() { Id = "2204", Name = "Ngay chua jong bao" };
            Console.WriteLine($"{s.Id} {s.Name} {s.RunToDeath()}");
            Drone d1 = new() { Name = "Nissan Gtr-34", Model = "Nismo", Manufacturer = "Nissan" };
            Console.WriteLine(d1.Run());
            Console.WriteLine(d1.RunToDeath());
            Console.WriteLine("==============");
            Racer[] race = new Racer[4];

            race[0] = new Student { Id = "Se172704", Name = "Toyota Supra", Gpa = 7.9, Yob = 2003 };
            race[1] = new Drone { Name = "Civic", Model = "Type R", Manufacturer = "Honda" };
            race[2] = d1;
            race[3] = s;

            foreach (var dr in race)
            {
                Console.WriteLine(dr.ShowRecord());
            }

            //Vi diệu - cọng dây thun - drift

        }
    }
}