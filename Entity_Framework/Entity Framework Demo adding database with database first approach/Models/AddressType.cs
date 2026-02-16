using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

/// <summary>
/// Types of addresses stored in the Address table. 
/// </summary>
public partial class AddressType
{
    /// <summary>
    /// Primary key for AddressType records.
    /// </summary>
    public int AddressTypeId { get; set; }

    /// <summary>
    /// Address type description. For example, Billing, Home, or Shipping.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<VendorAddress> VendorAddresses { get; set; } = new List<VendorAddress>();
}
