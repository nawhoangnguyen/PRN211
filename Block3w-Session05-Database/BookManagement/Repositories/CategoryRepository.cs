using Repositories.Context;
using Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Class này đóng vai class Cabinet đã học
    /// dùng để thao tác trên các object của clss Category
    /// tức là crud category và category lại map xuống table category
    /// nên class này sẽ xài DbContext để đẩy cái List<Category> lên xuống db
    /// CabinetV2 không chơi với ram mà chơi với DB  
    /// </summary>
    public class CategoryRepository
    {
        //khai báo Dbcontext để lên xuống db
        private BookManagement2023DbContext _db;          //nhớ new nha nha nha
        //đừng ghi như vầy new sau dùng hàm nào new hàm đó
        public List<BookCategory> GetAll()
        {
            _db = new();
            return _db.BookCategories.ToList();
        }
    }
}
