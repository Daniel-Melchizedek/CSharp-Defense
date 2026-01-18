using System;
using System.Collections.Generic;
using System.ComponentModel;
using APM.Utilities;

namespace APM.SL
{
  public class Discount
  {
    public int DiscountId { get; private set; }
    public string DiscountName { get; set; } = string.Empty;

    public decimal? PercentOff { get; set; }

    // ... Discount details

    public Discount? FindDiscount(List<Discount>? discounts, string discountName)
    {
      if (discounts is null) return null;

      var foundDiscount = discounts.Find(d => d.DiscountName == discountName);

      return foundDiscount;
    }

    public Discount FindDiscountWithException(List<Discount>? discounts, string discountName)
    {
      if (discounts is null) throw new ArgumentException("No discounts found",paramName: nameof(discounts));
      var foundDiscount = discounts.Find(d => d.DiscountName == discountName);

      if (foundDiscount is null)
      {
        throw new DiscountNotFoundException($"Discount not found.");
      }
      return foundDiscount;
    }

  }
}
