using System.Threading.Channels;

namespace Nawhn.DataType.DelegateAdvanceV3
{
    public delegate void SayXXX(); //MS public delegate void Action ()
    public delegate void SaySomething(string message);//MS public delegate void Action <số tham số>
    internal class Program
    {
        static void Main(string[] args)
        {
            //SayXXX x = SayCS;
            //x()

            //Action action = SayCS;
            //action();

            SaySomething x = SayMessage;
            x("Code xuyen trua");
            x = m => Console.WriteLine(m);
            x("Vai lambada hihi haha");

            //xài MS nhưung mà có tham số
            Action<string> i = SayMessage; // trỏ đến hàm có  style là một đầu vào kiểu chữ
            i("vai MS action");

            i = ahihi => Console.WriteLine(ahihi);


        }
        public static void SayCS() => Console.WriteLine("Hey C# afternoon");
        public static void SayMessage(string msg) => Console.WriteLine("Hey " + msg);
    }
}
//MUỐN CHƠI VỚI DELEGATE TA CẦN LÀM NHỮNG BƯỚC SAU:
//1. XÁC ĐỊNH STYLE VÀ LOẠI HÀM, ĐỊNH DẠNG HOÀM, ĐẦU VÀO ĐẦU RA CỦA HÀM]
//ví dụ id () | void (???) | ??? () | ??? (???)
//MỘT ĐẦU VÀO CÓ THỂ LÀ 1 ĐẦU VÀO HOẶC ĐIỀU ĐẦU VÀO 
//2. ĐỊNH  NGHĨA, TẠO RA NHÓM DELEGATE, DATA TYPE MỚI TRỎ TỚI STYLE HÀM ĐÃ CHỌN
//DÙNG LỆNH DELIGATE FORMAT HÀM BAO GỒM TÊN DELEAGTE
//VÍ DỤ: DELEGATE
//3. TẠO BIẾN CÓ KIỂU DELEGATE VIUAWF TẠO , DUNG PHÉP GÁN ĐỂ TRỎ ĐẾN ` HÀM NÀO ĐÓ CŨNG STULE
//VÍ DỤ : A X = ??? HÀM NÀODDOA CÙNG HÀM NÀO ĐÓCUNGF STYLE Ở ĐÂY, KO DÙNG NGOẶC TRÒN NHEN,KẺO HIỂU NHẦM
// CÓ THỂ DÙNG ANNONYMOUS METHOD, HOẶC LAMDA ĐỂ LÀM HÀM/TRỎ HÀM ONTHEGO TAKE Ư

//4. GỌ HÀM QUA 1 TRONG 2 CÚ PHÁP
//TÊN BIẾN (THAM SỐ)
//TÊN BIẾN MÔI TRƯỜNG(THAM SỐ)
//TÊN BIẾN (THAM SỐ)
//5. IN RA KÉT QUẢ TÙY Ý VÌ GIỐNG NHƯ GỌI HÀM BTH
//CHỐT DEAL 
//Microsoft THẤU HIỂU CÁI VIỆC CHÊS RA TÊN DELEGATE, CHẾ RA STYLE
//Microsoft  LÀM SẴN CHO MÌNH KHAI BÁO SẴN CHO CHÚ//MS DÙNG DELEGATE VÀ GEO ETRIC ĐỂ COVER TẤT CẢ CÁC LOẠI HINH TRÊN CUÔ

//MS ĐƯA RA 3 LOẠI DELEGATE CÓ SẴN TA DÙNG LUÔN
//Action :- dùng với hàm void ()
//acttions -> ứng với hàm có tối đa 8 đầu vào

//Func -> ứng với hàm có trả về, tối đa 16 đầu vào