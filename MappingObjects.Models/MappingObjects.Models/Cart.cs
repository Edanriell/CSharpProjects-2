﻿namespace Northwind.Entities;

public record class Cart(Customer Customer, List<LineItem> Items);
