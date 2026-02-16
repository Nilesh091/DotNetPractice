using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

/// <summary>
/// Lookup table containing the types of contacts stored in Contact.
/// </summary>
public partial class ContactType
{
    /// <summary>
    /// Primary key for ContactType records.
    /// </summary>
    public int ContactTypeId { get; set; }

    /// <summary>
    /// Contact type description.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<StoreContact> StoreContacts { get; set; } = new List<StoreContact>();

    public virtual ICollection<VendorContact> VendorContacts { get; set; } = new List<VendorContact>();
}
