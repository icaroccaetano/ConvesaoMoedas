using ConvesorMoedas.Dominio;


namespace ConversorMoedas.Teste
{
    public class TestesConverteMoedas
    {
        [Fact]
        public void Dado35ReaisDeveRetornar243LibrasE25Cents()
        {
            //Arrange
            ConverteMoedas converter = new ConverteMoedas();
            //Action
            var result = converter.ConverterReal(35, 2);
            //Assert
            Assert.Equal(243.25m, result);
        }
    }
}