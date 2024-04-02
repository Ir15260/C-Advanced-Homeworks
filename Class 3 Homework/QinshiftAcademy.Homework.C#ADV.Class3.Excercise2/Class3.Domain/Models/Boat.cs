

namespace Class3.Domain.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a boat and I do not have wheels :(");
        }
    }
}
