
using DepartmentAPI.Context;
using DepartmentAPI.Models;

namespace DepartmentAPI.Repositories;

public class DepartmentRepository : IDepartmentRepository
{
    public List<Department> AllDepartments()
    {
       using (var context =new CollectionContext())
       {
        var departments= context.Departments.ToList();
        return departments;
       }
    }

   
    public Department GetDepartmentById(int id)
    {
     using (var context =new CollectionContext())
       {
        var department= context.Departments.Find(id);
        
        return department;
       }  
    }

    public bool InsertDepartment(Department department)
    {
        using (var context =new CollectionContext())
       {
        context.Add(department);
        context.SaveChanges();
         return true;
       } 
       
    }

    public bool UpdateDepartment(Department department)
    {
      using (var context =new CollectionContext())
      {
        var OldDepartment= context.Departments.Find(department.Id);
        OldDepartment.Name=department.Name;
        OldDepartment.Location=department.Location;

        context.SaveChanges();
        return true;
      }
    }

     public bool DeleteDepartment(int id)
    {
       using(var context = new CollectionContext()){
         context.Departments.Remove(context.Departments.Find(id));  //GetDepartmentById(id)
         context.SaveChanges();
         return true;
       }
    }

}