namespace lab1.Models.ViewModels
{
    public class CategoryDTO
    {
        public CategoryDTO(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; } = "";
    }
}
