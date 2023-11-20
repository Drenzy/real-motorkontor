using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RealMotorkontor.Data
{
    public class CustomerService
    {
        CustomerDataAccessLayer objCustomerDAL { get; set; } = new();


        public string Create(Customer objCustomer)
        {
            objCustomerDAL.AddCustomer(objCustomer);
            return "Added Successfully";
        }

        public List<Customer> GetCustomer()
        {
            List<Customer> customers = objCustomerDAL.GetAllCustomers().ToList();
            return customers;
        }

        public Customer GetCustomerByID(int id)
        {
            Customer customer = objCustomerDAL.GetCustomerData(id);
            return customer;
        }
        public string UpdateCustomer(Customer objcustomer)
        {
            objCustomerDAL.UpdateCustomer(objcustomer);
            return "Update Successfully";
        }
        public string DeleteCustomer(Customer objcustomer)
        {
            objCustomerDAL.DeleteCustomer(objcustomer.CustomerId);
            return "Delete Successfully";
        }
    }
}
