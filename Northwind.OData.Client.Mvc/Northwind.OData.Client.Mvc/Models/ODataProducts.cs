﻿using Northwind.Shared; // Product

namespace Northwind.OData.Client.Mvc.Models;

public class ODataProducts
{
    public Product[]? Value { get; set; }
}
