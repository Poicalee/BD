using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Autor
{
    public int AuthorId { get; set; }

    public string? AuthorName { get; set; }

    public virtual ICollection<Ksiązki> Ksiązkis { get; set; } = new List<Ksiązki>();
}
