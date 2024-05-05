namespace FuelManagerGraphQL.Models
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Veiculo> Veiculos([Service] AppDbContext _context)
        {
            return _context.Veiculos;
        }
        public IQueryable<Consumo> Consumos([Service] AppDbContext _context)
        {
            return _context.Consumos;
        }
    }
}