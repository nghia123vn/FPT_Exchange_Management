﻿namespace FPT_Exchange_Data.Entities;

public partial class Category
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
