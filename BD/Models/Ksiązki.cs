using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Ksiązki
{
    public int BookId { get; set; }

    public int? AuthorId { get; set; }

    public int? PublicationYear { get; set; }

    public string? Title { get; set; }

    public string? Genre { get; set; }

    public bool? Available { get; set; }

    public virtual Autor? Author { get; set; }

    public virtual ICollection<Wypożyczenia> Wypożyczenia { get; set; } = new List<Wypożyczenia>();

    public virtual ICollection<Wypożyczenie> Wypożyczenies { get; set; } = new List<Wypożyczenie>();
}
