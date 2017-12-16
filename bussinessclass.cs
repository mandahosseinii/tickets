using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using layer3_DataClass;

namespace layer2_bussiness
{
    public class bussinessclass
    {
       
        public DataSet Orders_GetList()
        {
            Order or = new Order();
            return or.Orders_GetList();
        }

        public DataSet Orders_GetList_By_Type(int type)
        {
            Order or = new Order();
            return or.Orders_GetList_By_Type(type);
        }

        public void Orders_update(int id, string title, string desc, int vehicle, int price, int maxnumber, int beginning, int destination, string date, string time, int status)
        {
            Order or = new Order();
            or.Orders_update(id, title, desc, vehicle, price, maxnumber, beginning, destination, date, time, status);
        }

        public void Orders_insert(int id, string title, string desc, int vehicle, int price, int maxnumber, int beginning, int destination, string date, string time, int status)
        {
            Order or = new Order();
            or.Orders_insert(id, title, desc, vehicle, price, maxnumber, beginning, destination, date, time, status);

        }

        public void Orders_delete(int id)
        {
            Order or = new Order();
            or.Orders_delete(id);
        }


        public void Emp_insert( string name, string family, string father, string username, string password, string codemelli, string bdate, Int64 bprovince, Int64 bcity, Int64 bpart, Int64 bvillage, string sex, Int64 lprovince, Int64 lcity, Int64 lpart, Int64 lvillage, int madrak, int tell, int status)
        {
            Employee emp = new Employee();
            emp.Emp_insert( name, family, father, username, password, codemelli, bdate, bprovince, bcity, bpart, bvillage, sex, lprovince, lcity, lpart, lvillage, madrak, tell, status);

        }


        public void Emp_update(Int64 id, string name, string family, string father, string username, string password, string codemelli, string bdate, Int64 bprovince, Int64 bcity, Int64 bpart, Int64 bvillage, string sex, Int64 lprovince, Int64 lcity, Int64 lpart, Int64 lvillage, int madrak, int tell, int status)
        {
            Employee emp = new Employee();
            emp.Emp_update(id, name, family, father, username, password, codemelli, bdate, bprovince, bcity, bpart, bvillage, sex, lprovince, lcity, lpart, lvillage, madrak, tell, status);

        }

        public DataSet Emp_GetList()
        {
            Employee emp = new Employee();
            return emp.Emp_GetList();
                
        }

        public DataSet City_GetList()
        {
            City ct = new City();

            return ct.City_GetList();
        }

        public DataSet Vehicle_GetList()
        {
            Vehicle vh = new Vehicle();

            return vh.Vehicle_GetList();
        }

        public DataSet Select_Customer(Int64 id)
        {
            Customer cst = new Customer();

            return cst.Select_Customer(id);
        }

        public DataSet Customer_GetList()
        {
            Customer cst = new Customer();
            return cst.Customer_GetList();
        }

        public void Customer_insert( string name, string family, string father, string codemelli, string bdate, Int64 bprovince, Int64 bcity, Int64 bpart, Int64 bvillage, string sex, Int64 lprovince, Int64 lcity, Int64 lpart, Int64 lvillage, int madrak, int tell, int status)
        {
            Customer cst = new Customer();
            cst.Customer_insert( name, family, father, codemelli, bdate, bprovince, bcity, bpart, bvillage, sex, lprovince, lcity, lpart, lvillage, madrak, tell, status);

        }

        public void Customer_update(Int64 id, string name, string family, string father, string codemelli, string bdate, Int64 bprovince, Int64 bcity, Int64 bpart, Int64 bvillage, string sex, Int64 lprovince, Int64 lcity, Int64 lpart, Int64 lvillage, int madrak, int tell, int status)
        {
            Customer cst = new Customer();
            cst.Customer_update(id, name, family, father, codemelli, bdate, bprovince, bcity, bpart, bvillage, sex, lprovince, lcity, lpart, lvillage, madrak, tell, status);

        }

        public void OrderHistoryDetails_insert(int Employeeid, int OrderID, int CustomerID, int status)
        {
            OrderHistory orh = new OrderHistory();
            orh.OrderHistoryDetails_insert(Employeeid, OrderID, CustomerID, status);
        }
    }
}
