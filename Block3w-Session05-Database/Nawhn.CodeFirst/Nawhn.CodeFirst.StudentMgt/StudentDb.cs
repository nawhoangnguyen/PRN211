using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.CodeFirst.StudentMgt
{
    internal class StudentDb : DbContext
    {
        private string _connectionStr = "Server=(local);database=StudentDB;Uid=sa;Pwd=12345;TrustServerCertificate=true";
        //class này kế thừa class dbcontext có sẵn trong EFCore
        //nó chứa các lệnh để giúp ta móc nối xuống CSDL nào đó
        //nó chứa các lệnh khai báo giúp ta đồng bộ data trong object xuống DB và ngược lạo
        //để xài class DbContext ta cần khai báo 1 vài thông tin:
        //Chuỗi kết nối với sẻver (SQL Server.MySQL...)
        //Override hàm kết nối với CSDL dùng chuỗi kết nối của riêng ta

        public DbSet<Student>  Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring("");

            optionsBuilder.UseSqlServer(_connectionStr);
        }
        //Biến Students ngầm hiểu chính là List<Student> sẽ lấy từ CSDL lên
        //         *số nhiều            *số ít
        //SỐ NHIỀU CHÍNH LÀ TABLE TRONG TƯƠNG LAI - SỐ ÍT DÒNG/ROW/RECORD TRONG TƯƠNG LAI

        //Có bao nhiêu table/class muốn cất xuống Db thì khai báo thêm ở đây - dùng DbSet
        //lưu ý số ít và số nhiều
    }
}
