using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

/// <summary>
/// Companies from whom Adventure Works Cycles purchases parts or other goods.
/// </summary>
public partial class Vendor
{
    /// <summary>
    /// Primary key for Vendor records.
    /// </summary>
    public int VendorId { get; set; }

    /// <summary>
    /// Vendor account (identification) number.
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// Company name.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
    /// </summary>
    public byte CreditRating { get; set; }

    /// <summary>
    /// 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
    /// </summary>
    public bool PreferredVendorStatus { get; set; }

    /// <summary>
    /// 0 = Vendor no longer used. 1 = Vendor is actively used.
    /// </summary>
    public bool ActiveFlag { get; set; }

    /// <summary>
    /// Vendor URL.
    /// </summary>
    public string? PurchasingWebServiceUrl { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ProductVendor> ProductVendors { get; set; } = new List<ProductVendor>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<VendorAddress> VendorAddresses { get; set; } = new List<VendorAddress>();

    public virtual ICollection<VendorContact> VendorContacts { get; set; } = new List<VendorContact>();
}
