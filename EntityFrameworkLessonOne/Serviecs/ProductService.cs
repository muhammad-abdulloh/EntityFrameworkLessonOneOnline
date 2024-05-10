using EntityFrameworkLessonOne.DatabaseFolder;
using EntityFrameworkLessonOne.DTOs;
using EntityFrameworkLessonOne.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLessonOne.Serviecs
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteProduct(int Id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == Id);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        public async Task<Product> GetByIdProduct(int Id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == Id);

            return product;
        }

        public async Task<string> InsertProduct(ProductDTO productDTO)
        {
            var product  = new Product
            {
                Name = productDTO.Name,
                Unit = productDTO.Unit,
                Description = productDTO.Description,
                UnitPrice = productDTO.UnitPrice
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return "Product inserted";
        }

        public async Task<string> UpdateProduct(int Id, ProductDTO product)
        {
            var uProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == Id);

            uProduct.Name = product.Name;
            uProduct.Unit = product.Unit;
            uProduct.Description = product.Description;
            uProduct.UnitPrice = product.UnitPrice;
            await _context.SaveChangesAsync();

            return "Product updated";
        }
    }
}
