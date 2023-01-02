namespace InformationKeeper
{
    public interface IData
    {
        string Name { get; set; }
        string Description { get; set; }
        object this[string field] { get; set; }
    }
}
