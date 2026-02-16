using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

/// <summary>
/// Cross-reference table mapping customers in the Contact table to their credit card information in the CreditCard table. 
/// </summary>
public partial class ContactCreditCard
{
    /// <summary>
    /// Customer identification number. Foreign key to Contact.ContactID.
    /// </summary>
    public int ContactId { get; set; }

    /// <summary>
    /// Credit card identification number. Foreign key to CreditCard.CreditCardID.
    /// </summary>
    public int CreditCardId { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual CreditCard CreditCard { get; set; } = null!;
}
