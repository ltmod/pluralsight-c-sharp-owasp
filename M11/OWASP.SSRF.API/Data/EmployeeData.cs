namespace OWASP.SSRF.API.Data;

public class EmployeeData
{
    public EmployeeData()
    {
        Employees = new List<Employee>
        {
            new Employee
            {
                BusinessEntityID = 1,
                NationalIDNumber = "295847284",
                LoginID = "adventure-works\\ken0",
                JobTitle = "Chief Executive Officer",
                BirthDate = DateTime.Parse("1969-01-29"),
                MaritalStatus = "S",
                Gender = "M",
                HireDate = DateTime.Parse("2009-01-14"),
                SalariedFlag = true,
                VacationHours = 99,
                SickLeaveHours = 69,
                CurrentFlag = true,
                Rowguid = Guid.Parse("F01251E5-96A3-448D-981E-0F99D789110D"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 2,
                NationalIDNumber = "245797967",
                LoginID = "adventure-works\\terri0",
                JobTitle = "Vice President of Engineering",
                BirthDate = DateTime.Parse("1971-08-01"),
                MaritalStatus = "S",
                Gender = "F",
                HireDate = DateTime.Parse("2008-01-31"),
                SalariedFlag = true,
                VacationHours = 1,
                SickLeaveHours = 20,
                CurrentFlag = true,
                Rowguid = Guid.Parse("45E8F437-670D-4409-93CB-F9424A40D6EE"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 3,
                NationalIDNumber = "509647174",
                LoginID = "adventure-works\\roberto0",
                JobTitle = "Engineering Manager",
                BirthDate = DateTime.Parse("1974-11-12"),
                MaritalStatus = "M",
                Gender = "M",
                HireDate = DateTime.Parse("2007-11-11"),
                SalariedFlag = true,
                VacationHours = 2,
                SickLeaveHours = 21,
                CurrentFlag = true,
                Rowguid = Guid.Parse("9BBBFB2C-EFBB-4217-9AB7-F97689328841"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 4,
                NationalIDNumber = "112457891",
                LoginID = "adventure-works\\rob0",
                JobTitle = "Senior Tool Designer",
                BirthDate = DateTime.Parse("1974-12-23"),
                MaritalStatus = "S",
                Gender = "M",
                HireDate = DateTime.Parse("2007-12-05"),
                SalariedFlag = false,
                VacationHours = 48,
                SickLeaveHours = 80,
                CurrentFlag = true,
                Rowguid = Guid.Parse("59747955-87B8-443F-8ED4-F8AD3AFDF3A9"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 5,
                NationalIDNumber = "695256908",
                LoginID = "adventure-works\\gail0",
                JobTitle = "Design Engineer",
                BirthDate = DateTime.Parse("1952-09-27"),
                MaritalStatus = "M",
                Gender = "F",
                HireDate = DateTime.Parse("2008-01-06"),
                SalariedFlag = true,
                VacationHours = 5,
                SickLeaveHours = 22,
                CurrentFlag = true,
                Rowguid = Guid.Parse("EC84AE09-F9B8-4A15-B4A9-6CCBAB919B08"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 6,
                NationalIDNumber = "998320692",
                LoginID = "adventure-works\\jossef0",
                JobTitle = "Design Engineer",
                BirthDate = DateTime.Parse("1959-03-11"),
                MaritalStatus = "M",
                Gender = "M",
                HireDate = DateTime.Parse("2008-01-24"),
                SalariedFlag = true,
                VacationHours = 6,
                SickLeaveHours = 23,
                CurrentFlag = true,
                Rowguid = Guid.Parse("E39056F1-9CD5-478D-8945-14ACA7FBDCDD"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 7,
                NationalIDNumber = "134969118",
                LoginID = "adventure-works\\dylan0",
                JobTitle = "Research and Development Manager",
                BirthDate = DateTime.Parse("1987-02-24"),
                MaritalStatus = "M",
                Gender = "M",
                HireDate = DateTime.Parse("2009-02-08"),
                SalariedFlag = true,
                VacationHours = 61,
                SickLeaveHours = 50,
                CurrentFlag = true,
                Rowguid = Guid.Parse("4F46DECA-EF01-41FD-9829-0ADAB368E431"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 8,
                NationalIDNumber = "811994146",
                LoginID = "adventure-works\\diane1",
                JobTitle = "Research and Development Engineer",
                BirthDate = DateTime.Parse("1986-06-05"),
                MaritalStatus = "S",
                Gender = "F",
                HireDate = DateTime.Parse("2008-12-29"),
                SalariedFlag = true,
                VacationHours = 62,
                SickLeaveHours = 51,
                CurrentFlag = true,
                Rowguid = Guid.Parse("31112635-663B-4018-B4A2-A685C0BF48A4"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 9,
                NationalIDNumber = "658797903",
                LoginID = "adventure-works\\gigi0",
                JobTitle = "Research and Development Engineer",
                BirthDate = DateTime.Parse("1979-01-21"),
                MaritalStatus = "M",
                Gender = "F",
                HireDate = DateTime.Parse("2009-01-16"),
                SalariedFlag = true,
                VacationHours = 63,
                SickLeaveHours = 51,
                CurrentFlag = true,
                Rowguid = Guid.Parse("50B6CDC6-7570-47EF-9570-48A64B5F2ECF"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            },
            new Employee
            {
                BusinessEntityID = 10,
                NationalIDNumber = "879342154",
                LoginID = "adventure-works\\michael6",
                JobTitle = "Research and Development Manager",
                BirthDate = DateTime.Parse("1984-11-30"),
                MaritalStatus = "M",
                Gender = "M",
                HireDate = DateTime.Parse("2009-05-03"),
                SalariedFlag = true,
                VacationHours = 16,
                SickLeaveHours = 64,
                CurrentFlag = true,
                Rowguid = Guid.Parse("EAA43680-5571-40CB-AB1A-3BF68F04459E"),
                ModifiedDate = DateTime.Parse("Jun 30 2014 12:00AM")
            }
        };
    }

    public List<Employee> Employees { get; set; }

    public List<Employee> GetAllEmployees()
    {
        return Employees;
    }
}