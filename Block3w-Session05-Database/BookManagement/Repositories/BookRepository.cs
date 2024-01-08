using Repositories.Context;
using Repositories.Entity;

namespace Repositories
{

    /// <summary>
    /// Class này chơi trực tiếp với cơ sở dữ liệu 
    /// tức là nó xài dbcontext đẻ crud table
    /// và class này sẽ được gọi bởi class service
    /// Class này sẽ chứa các hàm CRUD cơ bản trên table Book, có thể sẽ phải join với Category
    /// Tên các hàm đặt sát với mức SQL - Create/Update/Delete/GetAll
    /// </summary>
    public class BookRepository
    {
        private BookManagement2023DbContext _db;
        public List<Book> GetAll()
        {
            _db = new BookManagement2023DbContext();
            return _db.Books.ToList();
        }        
        
    }
}