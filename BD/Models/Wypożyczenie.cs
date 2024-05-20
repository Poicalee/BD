using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Wypożyczenie
{
    public int LoanId { get; set; }

    public int? BookId { get; set; }

    public int? ReaderId { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly? LoanDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public bool? Returned { get; set; }

    public virtual Ksiązki? Book { get; set; }

    public virtual Pracownik? Employee { get; set; }

    public virtual Czytelnik? Reader { get; set; }
}
