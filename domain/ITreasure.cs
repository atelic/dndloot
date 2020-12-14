namespace DnDLoot.Domain
{
    public interface ITreasure
    {
        string GetSmall(int roll);
        string GetMedium(int roll);
        string GetLarge(int roll);
        string GetExtraLarge(int roll);
    }
}
