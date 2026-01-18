using System;
using System.Collections.Generic;
using APM.Utilities;
using Xunit;

namespace APM.SL.Test
{
  public class DiscountTest
  {
    //
    // FindDiscount
    //
    [Fact]
    //discount not found exception
    public void FindDiscountWithException_DiscountNotFound_ThrowsDiscountNotFoundException()
    {
      // Arrange
      var discountService = new Discount();
      var discounts = new List<Discount>
      {
        new Discount { DiscountName = "Summer Sale", PercentOff = 0.15M },
        new Discount { DiscountName = "Winter Sale", PercentOff = 0.20M }
      };
      var discountNameToFind = "Spring Sale";

      // Act & Assert

      try
      {
      discountService.FindDiscountWithException(null, discountNameToFind);
      }

      catch(DiscountNotFoundException exception)
      {
        Assert.Equal("Discount not found.", exception.Message);
      }
      catch (ArgumentException exception) when (exception.ParamName == "discount")
      {
        Assert.Equal("No discounts found (Parameter 'discounts')", exception.Message);
      }


    }

  }
}
