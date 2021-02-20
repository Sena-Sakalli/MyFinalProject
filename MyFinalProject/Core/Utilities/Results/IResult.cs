using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //start for basic void
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
