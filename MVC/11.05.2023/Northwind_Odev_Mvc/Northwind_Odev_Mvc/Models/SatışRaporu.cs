using System;
using System.Collections.Generic;

namespace Northwind_Odev_Mvc.Models;

public partial class SatışRaporu
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public string ProductName { get; set; } = null!;
}
