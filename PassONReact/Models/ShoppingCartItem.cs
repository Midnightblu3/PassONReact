using System;
using System.Collections.Generic;

namespace PassONReact.Models;

public partial class ShoppingCartItem
{
    public int ShoppingCartItemId { get; set; }

    public int ItemId { get; set; }

    public int Amount { get; set; }

    public string? ShoppingCardId { get; set; }

    public virtual Item Item { get; set; } = null!;
}
