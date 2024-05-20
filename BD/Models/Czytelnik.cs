using System;
using System.Collections.Generic;

namespace BD1.Models;

public partial class Czytelnik
{
    public int ReaderId { get; set; }

    public string? ReaderName { get; set; }

    public string? ReaderAddress { get; set; }

    public string? ReaderPhone { get; set; }

    public virtual ICollection<Wypożyczenium> Wypożyczenia { get; set; } = new List<Wypożyczenium>();

    public virtual ICollection<Wypożyczenie> Wypożyczenies { get; set; } = new List<Wypożyczenie>();
}
