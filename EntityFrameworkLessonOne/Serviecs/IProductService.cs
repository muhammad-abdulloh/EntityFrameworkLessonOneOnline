using EntityFrameworkLessonOne.DTOs;
using EntityFrameworkLessonOne.Models;

namespace EntityFrameworkLessonOne.Serviecs
{
    public interface IProductService
    {
        public Task<string> InsertProduct(ProductDTO productDTO);
        public Task<Product> GetByIdProduct(int Id);
        public Task<IEnumerable<Product>> GetAllProducts();
        public Task<string> UpdateProduct(int Id, ProductDTO product);
        public Task<bool> DeleteProduct(int Id);
    }

}
