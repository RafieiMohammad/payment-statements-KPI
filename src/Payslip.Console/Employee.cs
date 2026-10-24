
public class Employee
{
    public string FullName {get ; set ;}
    public string PersonnelNo {get ;}
    public bool IsActive {get ; private set ;} = true;

        public Employee(string fullName, string personnelNo)
    {
        FullName = fullName;
        PersonnelNo = personnelNo;
    }

    public void Deactivate()
    {
        IsActive = false;
    }


}
