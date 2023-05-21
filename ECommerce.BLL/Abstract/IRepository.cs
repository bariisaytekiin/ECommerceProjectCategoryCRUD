using ECommerce.Entity.Base;


namespace ECommerce.BLL.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List
        IEnumerable<T> GetAll();//List içerisinde list dönmemizi sağlamak için kullanılıyor.Kendi içinde foreach olan list.
        //Creat

        string Create(T entity);

        //Delete
        string Delete(T entity);//int koymuyoruz çünkü ileride id int olmaya bilir.

        //Update
        string Update(T entity);

        //Find
        T GetById(int id);

    }
}
