﻿using AntraDay3.DataModel;

namespace AntraDay3.Repository;

public class CustomerRepository : IRepository <Customer>
{
    List<Customer> customers = new List<Customer>();
    
    public int Insert(Customer obj)
    {
        if (GetById(obj.Id) == null)
        {
            customers.Add(obj);
            return 1;
        }
        
        return 0;
    }

    public int Update(Customer obj)
    {
        Customer c = GetById(obj.Id);
        if (c != null)
        {
            c.Id = obj.Id;
            c.Name = obj.Name;
            c.Email = obj.Email;
            return 1;
        }
        
        return 0;
    }

    public int Delete(int id)
    {
        Customer c = GetById(id);
        if (c != null)
        {
            customers.Remove(c);
            return 1;
        }
        
        return 0;
    }

    public List<Customer> GetAll()
    {
        return customers;
    }

    public Customer GetById(int id)
    {
        for (int i = 0; customers.Count > i; i++)
        {
            if (customers[i].Id == id) return customers[i];
        }
        
        return null;
    }
}