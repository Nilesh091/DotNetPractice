using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

public partial class VSalesPersonSalesByFiscalYear
{
    public int? SalesPersonId { get; set; }

    public string? FullName { get; set; }

    public string Title { get; set; } = null!;

    public string SalesTerritory { get; set; } = null!;

    public decimal? _2002 { get; set; }

    public decimal? _2003 { get; set; }

    public decimal? _2004 { get; set; }
}
