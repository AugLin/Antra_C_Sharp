using AntraCSHW3.DataModel;

namespace AntraCSHW3.Repository;

public class ProductRepository : IRepository<Product>
{
    private List<Product> _products = new List<Product>();
    
    public void Add(Product obj)
    {
        _products.Add(obj);
    }

    public void Remove(Product obj)
    {
        if (GetById(obj.ProductId) != null)
        {
            _products.Remove(obj);
        }
    }

    public void Save(int id)
    {
        foreach (var product in _products)
        {
            if (product.ProductId == id)
            {
                Console.WriteLine($"ProductId : {product.ProductId}, ProductName : {product.ProductName}, Product Price : {product.ProductPrice}");
            }
        }
    }

    public IEnumerable<Product> GetAll()
    {
        return _products;
    }

    public Product GetById(int id)
    {
        foreach (var product in _products)
        {
            if (product.ProductId == id) return product;
        }

        return null;
    }
}