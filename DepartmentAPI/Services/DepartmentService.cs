

using DepartmentAPI.Models;
using DepartmentAPI.Repositories;

namespace DepartmentAPI.Services;

public class DepartmentService : IDepartmentService
{

    private readonly IDepartmentRepository _repository;  

    public DepartmentService(IDepartmentRepository repository)  
    {
        this._repository=repository;
    }
    public List<Department> AllDepartments()
    {
        return _repository.AllDepartments();
    }

   

    public Department GetDepartmentById(int id)
    {
        return _repository.GetDepartmentById(id);
    }

    public bool InsertDepartment(Department department)
    {
        return _repository.InsertDepartment(department);
    }

    public bool UpdateDepartment(Department department)
    {
        return _repository.UpdateDepartment(department);
    }

     public bool DeleteDepartment(int id)
    {
       return _repository.DeleteDepartment(id);
    }
}