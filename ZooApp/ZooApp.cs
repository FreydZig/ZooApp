namespace ZooLab
{
    public class ZooApp
    {
        List<Zoo> _zoos = new List<Zoo>();
        void AddZoo(Zoo zoo)
        {
            _zoos.Add(zoo);
        }
    }
}