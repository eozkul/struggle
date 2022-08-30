using Struggle.Common;
namespace Struggle.Data.Requests.Contracts
{
    public class CarDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public string Name { get; set; }
        public bool HeadLights { get; set; }    
    }
}
