using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Pracownik
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeePosition { get; set; }

    public decimal? EmployeeSalary { get; set; }

    public string? EmployeeAddress { get; set; }

    public string? EmployeePhone { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }


    public virtual ICollection<Wypożyczenie> Wypożyczenies { get; set; } = new List<Wypożyczenie>();
}
