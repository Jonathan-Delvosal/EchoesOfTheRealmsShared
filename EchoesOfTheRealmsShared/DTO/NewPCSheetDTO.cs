using System.Xml.XPath;

namespace EchoesOfTheRealmsShared.DTO
{
    public class NewPCSheetDTO
    {

        public string Name { get; set; } = null!;

        public int JobId { get; set; }

        public JobDTO? Job { get; set; }

    }
}
