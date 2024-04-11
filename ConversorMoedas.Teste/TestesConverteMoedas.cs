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
            var result = converter.ConverterTester(35, 2);
            //Assert
            Assert.Equal(243.25m, result);
        }

        [Fact]
        public void Dado15ReaisE47CentsDeveRetornar0IenesE80Cents()
        {
            //Arrange
            ConverteMoedas converter = new ConverteMoedas();
            //Action
            var result = converter.ConverterTester(15.47m, 3);
            //Assert
            Assert.Equal(0.80444m, result);
        }
    }
}