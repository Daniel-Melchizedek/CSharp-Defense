using System;

namespace APM.Utilities;

[Serializable()]
public class DiscountNotFoundException: System.ArgumentException
{
    public DiscountNotFoundException():base()
    {
        
    }

    public DiscountNotFoundException(string message): base(message)
    {
        
    }

    public DiscountNotFoundException(string message, string paramName): base(message,paramName)
    {
      
    }

    public DiscountNotFoundException(string message, Exception inner):base(message, inner)
    {
        
    }
    protected DiscountNotFoundException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context): base(info, context)
    {
    }
}
