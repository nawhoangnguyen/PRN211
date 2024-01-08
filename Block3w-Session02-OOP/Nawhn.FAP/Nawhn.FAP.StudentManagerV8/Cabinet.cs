namespace Nawhn.FAP.StudentManagerV8
{
    internal class Cabinet<T> // T: type - 1 loại class nào đó để đưa vào
    {                         // t <Student> <Lecturer> <Sale> <Customer>
        //KĨ THUẬT GENERIC, KHI DATA TYPE LẠI LÀ 1 THAM SỐ, XÀI DATA TYPE NÀO THÌ ĐƯA 
        //DATA TYPE ĐÓ VÀO, MẢNG SẼ LÀ MẢNG CỦA DATA TYPE TƯƠNG ỨNG
        //private Student[] _list = new Student[30];
        //private Lecturer[] _list1 = new Lecturer[30];
        //không dùng cách này nữa

        private T[] _list = new T[30];
        private int _count = 0;
        public void AddNew(T s)
        {
            //hàm này nhập thông tin từ đâu đó, đưa nguyên con new Student, object tham chiếu vào 
            _list[_count] = s;
            _count++;
        }
        public void PrintList()
        {
            Console.WriteLine($"There is/are {_count} person(s) in the list");
            //ko thể for hết hay foreach do mảng chưa đầy
            //nên chir for đến count
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i].ToString());
            }
        }

        //TẠI THỜI ĐIỂM NÀY TA CHƯA LÀM HÀM SORT ĐƯỢC TẠI CHƯA BIÉT OBJECT 
        //ĐƯA VÀO LÀ ĐỨA NÀO <Student> <Customer> <Lecturer> MỖI LOẠI CÓ PROPERTY
        //KHÁC NHAU
        //TA CHƯA BIẾT _list[i] CHẤM CÁI GÌ ĐỂ SORT ĐƯỢC
        //ĐỂ SORT ĐC CGAAOS T LÀ GÌ, TA DÙNG KĨ THUẬT CỰC HAY: DEPENDENCY INJECTION
        //                  kẾT HỢP DELEGATE - ỦY QUYỀN
        //JAVA - DEPENDENCY INJECTION + FUNCTIONAL INTERFACE + LAMBDA EXPRESSION
    }

}
