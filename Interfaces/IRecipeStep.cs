namespace MEalAPI.Interfaces
{
    public interface IRecipeStep
    {
        public long Id { get; set; }

        public int Order { get; set; }

        public string Content { get; set; }
    }
}
