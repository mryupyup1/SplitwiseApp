using System;
using System.Collections.Generic;

namespace Registration.Models;

public partial class User
{
    public int UserId { get; set; }

    public string EmailId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? LasteName { get; set; }

    public string? PhoneNumber { get; set; }

    public string Password { get; set; } = null!;
}
