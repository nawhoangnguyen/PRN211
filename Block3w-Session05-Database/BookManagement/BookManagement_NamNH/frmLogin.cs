using Repositories.Entity;
using Services;

namespace BookManagement_NamNH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CategoryService ser = new CategoryService();
            cboCategory.DataSource = ser.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType"; //drop hiển thị cột nào
                                                         //từ table/class/company
                                                         //khi user chọn 1 dòng
            cboCategory.ValueMember = "BookCategoryId";  //khi ngầm định lấy cột nào
                                                         //Ví dụ: user chon khoa học GT
                                                         //tức là user chon số category 2
                                                         //chính là khóa ngoại loại cuốn sách

            cboCategory.SelectedValue = 4;


            //string listOfCat = "";                     

            //List<BookCategory> list = ser.GetAllCategories();
            //ta đã lấy đc toàn bộ Category từ DB
            //lấy text để gán vào biến chuỗi
            //for (int i = 0; i < list.Count; i++)
            //{
            //    listOfCat += list[i].BookCategoryId + " | " + list[i].Description + " | " + list[i].BookGenreType + "\n";
            //}
            //MessageBox.Show(listOfCat);
            //hàm show popup của class message box có sẵn trong dotnet framework
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookMgt frmBookMgt = new frmBookMgt();
            frmBookMgt.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}