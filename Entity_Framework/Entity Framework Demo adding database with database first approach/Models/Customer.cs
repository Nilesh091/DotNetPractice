using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

/// <summary>
/// Current customer information. Also see the Individual and Store tables.
/// </summary>
public partial class Customer
{
    /// <summary>
    /// Primary key for Customer records.
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
    /// </summary>
    public int? TerritoryId { get; set; }

    /// <summary>
    /// Unique number identifying the customer assigned by the accounting system.
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// Customer type: I = Individual, S = Store
    /// </summary>
    public string CustomerType { get; set; } = null!;

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual Individual? Individual { get; set; }

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } = new List<SalesOrderHeader>();

    public virtual Store? Store { get; set; }

    public virtual SalesTerritory? Territory { get; set; }
}
