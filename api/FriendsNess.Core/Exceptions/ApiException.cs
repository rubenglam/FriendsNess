using FriendsNess.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Exceptions;

public class ApiException : Exception
{
    private readonly IEnumerable<string> _errors = new List<string>();

    public ApiException(IEnumerable<string> errors)
    {
        _errors = errors;
    }

    public ApiException(string error)
    {
        _errors = new List<string> { error };
    }

    public IEnumerable<string> Errors => _errors;
}
