using Core.Models.Base;

namespace Core.Models.CrmSchema;

public class Customer : PersonBase
{
    public string CustomerNumber { get; set; } = string.Empty;
}
