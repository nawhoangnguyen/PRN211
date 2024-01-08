using Repositories.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_NamNH
{
    public partial class frmBookMgt : Form
    {
        private BookService _service = new BookService();
        public frmBookMgt()
        {
            InitializeComponent();
        }

        private void frmBookMgt_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = _service.GetAllBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Book> re = _service.SearchAllBooks(txtKeyword.Text.ToLower());
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = re;           
        }
    }
}
