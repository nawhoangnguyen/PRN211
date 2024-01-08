using Repositories;
using Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Class này cung cấp các hàm cho bên UI - Form sử dụng để load dât
    /// hoặc nhận dât từ UI - Form
    /// Nó giao tiếp với repo để đồng bộ data với CSDL
    /// Tên hàm đặt rõ ràng dễ hiểu vì cung cấp cho bên UI xài !!!
    /// Cơ bản vẫn là (CRUD)
    /// </summary>
    public class BookService
    {
        BookRepository _repo;
        public List<Book> GetAllBooks()
        {
            _repo = new BookRepository();
            return _repo.GetAll();
        }
        public List<Book> SearchAllBooks(string msg)
        {
            List<Book> result = _repo.GetAll();
            List<Book> books = result.Where(x =>
            {
                if (x.BookName.ToLower().Contains(msg) || x.Description.ToLower().Contains(msg))
                {
                    return true;
                }
                return false;
            }).ToList();
            return books;
        }
    }
}
