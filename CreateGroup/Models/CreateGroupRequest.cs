namespace CreateGroup.Models
{
    public class CreateGroupRequest
    {

        public string GroupName { get; set; }
        public List<string> UserNames { get; set; }
    }
}
