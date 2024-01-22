using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ShoeStore
{
    private List<Shoe> shoes;
    private int count;

    public ShoeStore(string name, int storageCapacity)
    {
        this.Name = name;
        this.StorageCapacity = storageCapacity;
        shoes = new List<Shoe>();
    }

    public string Name { get; set; }
    public int StorageCapacity { get; set; }
    public int Count { get { return shoes.Count; } }
    public string AddShoe(Shoe shoe)
    {
        if (shoes.Count == StorageCapacity)
        {
            return "No more space in the storage room.";
        }
        shoes.Add(shoe);
        return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
    }
    public int RemoveShoes(string material)
    {
        int num = shoes.RemoveAll(sh => sh.Material == material);
        return num;
    }
    public List<Shoe> GetShoesByType(string type)
    {
        return shoes.Where(x => x.Type == type).ToList();

    }
    public Shoe GetShoeBySize(double size)
    {
        Shoe shoe = shoes.Where(x => x.Size == size).FirstOrDefault();
        return shoe;
    }
    public string StockList(double size, string type)
    {
        var matchingShoes = shoes.Where(s => s.Size == size && s.Type == type).ToList();
        StringBuilder sb = new StringBuilder();
        if (matchingShoes.Count > 0)
        {
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            matchingShoes.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
        return $"No stock available for size {size} - {type} shoes.";

    }
}

