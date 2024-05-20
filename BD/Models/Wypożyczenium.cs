using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Wypożyczenium
{
    public int WypId { get; set; }

    public int? BookId { get; set; }

    public int? ReaderId { get; set; }

    public DateOnly? LoanDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public bool? Returned { get; set; }

    public virtual Ksiązki? Book { get; set; }

    public virtual Czytelnik? Reader { get; set; }
}
