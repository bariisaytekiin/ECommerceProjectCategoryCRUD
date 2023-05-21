using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractService;
using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public string CreateCategory(Category category)
        {
            try
            {
                _categoryRepository.Create(category);
                return "Veri Eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteCategory(Category category)
        {
            try
            {
                category.Status = ECommerce.Entity.Enum.Status.Deleted;

                return _categoryRepository.Update(category);//Satatğsğnğ değiştirmek için update gönderdik.String bir sonuç döndüğü için returne bağladık.
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Category FindCategory(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public string UpdateCategory(Category category)
        {
            try
            {
                category.Status = ECommerce.Entity.Enum.Status.Updated;
                return _categoryRepository.Update(category);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll().ToList();
        }

       
    }
}
