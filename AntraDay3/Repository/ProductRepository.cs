using AntraDay3.DataModel;

namespace AntraDay3.Repository;

public class ProductRepository: IRepository<Products>
{
    List<Products> products = new List<Products>();
    public int Insert(Products obj)
    {
        throw new NotImplementedException();
    }

    public int Update(Products obj)
    {
        throw new NotImplementedException();
    }

    public int Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Products> GetAll()
    {
        throw new NotImplementedException();
    }

    public Products GetById(int id)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].ProductId == id)
            {
                return products[i];
            }
        }

        return null;
    }
}