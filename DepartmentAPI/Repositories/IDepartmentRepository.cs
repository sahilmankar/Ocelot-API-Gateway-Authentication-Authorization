using DepartmentAPI.Models;

namespace DepartmentAPI.Repositories;
public interface IDepartmentRepository
{

    List<Department> AllDepartments();

    Department GetDepartmentById(int id);

    bool InsertDepartment(Department department);

    bool UpdateDepartment(Department department);

     bool DeleteDepartment(int id);

}