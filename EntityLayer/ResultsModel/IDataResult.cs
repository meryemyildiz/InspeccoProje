using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.ResultsModel
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
