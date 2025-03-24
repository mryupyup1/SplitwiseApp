using System;
using System.Collections.Generic;

namespace CreateGroup.Models;

public partial class Group
{
    public int GroupId { get; set; }

    public string? GroupMemberNames { get; set; }

    public string? GroupStatus { get; set; }

    public string? GroupName { get; set; }
}
