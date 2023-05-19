public interface ICharacter
{
    public Inventory Inventory { get; }

    public int Health { get; }

    public int Level { get; }

    void OnItemEquipped(Item item);
}
