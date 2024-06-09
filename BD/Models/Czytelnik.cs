using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Czytelnik
{
    public int ReaderId { get; set; }

    public string? ReaderName { get; set; }

    public string? ReaderAddress { get; set; }

    public string? ReaderPhone { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Wypożyczenia> Wypożyczenia { get; set; } = new List<Wypożyczenia>();

    public virtual ICollection<Wypożyczenie> Wypożyczenies { get; set; } = new List<Wypożyczenie>();
}
