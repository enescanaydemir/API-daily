using System;

namespace ApiDaily.Entity;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }
}