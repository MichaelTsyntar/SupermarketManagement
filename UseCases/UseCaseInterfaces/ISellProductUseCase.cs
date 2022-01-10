namespace UseCases
{
    public interface ISellProductUseCase
    {
        void Execute(string casierName, int productId, int qtyToSell);
    }
}