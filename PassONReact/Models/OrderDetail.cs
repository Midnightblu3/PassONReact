using System;
using System.Collections.Generic;

namespace PassONReact.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public int ItemId { get; set; }

    public int Amount { get; set; }

    public decimal Price { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
