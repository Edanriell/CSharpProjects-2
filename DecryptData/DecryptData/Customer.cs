﻿namespace Northwind.Shared;

public record class Customer(string Name, string CreditCard, string Password, string Salt);
