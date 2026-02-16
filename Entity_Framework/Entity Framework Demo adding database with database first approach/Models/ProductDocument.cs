using System;
using System.Collections.Generic;

namespace Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

/// <summary>
/// Cross-reference table mapping products to related product documents.
/// </summary>
public partial class ProductDocument
{
    /// <summary>
    /// Product identification number. Foreign key to Product.ProductID.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Document identification number. Foreign key to Document.DocumentID.
    /// </summary>
    public int DocumentId { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
