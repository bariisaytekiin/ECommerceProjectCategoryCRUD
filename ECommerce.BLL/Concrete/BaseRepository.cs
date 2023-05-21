using ECommerce.BLL.Abstract;
using ECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DAL;
using ECommerce.DAL.Contex;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity//farklı bir tip gönderilmesin diye base repositorye t gönderdik
    {

        private readonly EcommersContext _context;
        private readonly DbSet<T> _entities; //Products

        public BaseRepository(EcommersContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }


        public string Create(T entity)
        {
            try
            {
                //_context.Set<T>().Add(entity);Cast işlrmi
                _entities.Add(entity);//Cast işlrmi
                _context.SaveChanges();
                return "veri kaydedildi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(T entity)
        {
            try
            {
                #region Veriyi veritabanından kaldırmak istersek
                //var deleted = GetById(entity.Id);
                //_entities.Remove(deleted);
                //_context.SaveChanges();
                //return "veri silindi!"; 
                #endregion

                var deleted = GetById(entity.Id);
                deleted.Status = ECommerce.Entity.Enum.Status.Deleted;
                //Updated
                Update(deleted);
                return "veri silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(x => x.Status == ECommerce.Entity.Enum.Status.Created || x.Status == ECommerce.Entity.Enum.Status.Updated);
        }

        public T GetById(int id)
        {
            var entity = _entities.Find(id);
            return entity;
        }


        //todo: Güncelleme test işlemi
        public string Update(T entity)
        {
            string result = "";
            try
            {
                switch (entity.Status)
                {
                    case ECommerce.Entity.Enum.Status.Created:
                    case ECommerce.Entity.Enum.Status.Updated:
                        entity.Status = ECommerce.Entity.Enum.Status.Updated;
                        /*_context.Entry(entity).State = EntityState.Modified;*/
                        var updated = _context.Categories.Find(entity.Id);
                        _context.Entry(updated).CurrentValues.SetValues(entity);
                        _context.SaveChanges();
                        result = "veri güncellendi";
                        break;
                    case ECommerce.Entity.Enum.Status.Deleted:
                        entity.Status = ECommerce.Entity.Enum.Status.Deleted;
                        _context.SaveChanges();
                        result = "veri güncellendi";
                        break;


                }
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            return result;
        }
    }
}
