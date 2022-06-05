using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos;

public class ErrorResponse
{
    public ErrorResponse(IEnumerable<string> errors)
    {
        Errors = errors;
    }

    public ErrorResponse(string error)
    {
        Errors = new List<string>() { error };
    }

    public IEnumerable<string> Errors { get; set; } = new List<string>();
}
