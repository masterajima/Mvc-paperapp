namespace Azima1Books.DataAccess.Data
{
    public class Product
    {
        internal object ISBN;

        public object Id { get; internal set; }
        public object ImageUrl { get; internal set; }
        public object CoverTypeId { get; internal set; }
        public object Title { get; internal set; }
        public object Description { get; internal set; }
        public object Author { get; internal set; }
        public object ListPrice { get; internal set; }
        public object Price { get; internal set; }
        public object Price50 { get; internal set; }
        public object Price100 { get; internal set; }
        public object CategoryId { get; internal set; }
    }
}