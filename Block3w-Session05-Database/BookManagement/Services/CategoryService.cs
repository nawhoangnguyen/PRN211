using Repositories;
using Repositories.Entity;

namespace Services
{
    /// <summary>
    /// class này lấy data từ form hiển thị cho user
    /// hoặc lấy data từ form - ui đẩy ngược lại xuống Repo xuống DB
    /// chứa các hàm gọi crud từ repo, có thể xào nấu tính toán dùng LINQ
    /// Nên gọi là bên cung cấp dịch vụ - sẻvice cho user - ui     
    /// tên hàm ở đây mang ý nghĩa rõ rang hơn tên hàm trong REPO
    /// Repo: Create/Update/Delete/Insert/Select/Get
    /// Service: CreateCategory/AddCategory/UpdateCategory
    /// Form: chính là thực khách
    /// </summary>
    public class CategoryService
    {
        private CategoryRepository _repo = new();
        public List<BookCategory> GetAllCategories() => _repo.GetAll();

    }
}