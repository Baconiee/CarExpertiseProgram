using System.Collections.Generic;

public class EditUserViewModel
{
    public string Id { get; set; }
    public string Email { get; set; }
    public IList<string> Roles { get; set; }
}
