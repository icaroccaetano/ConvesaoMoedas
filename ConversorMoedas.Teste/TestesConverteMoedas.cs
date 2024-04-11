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
        public void Dado15ReaisE47CentsDeveRetornar0IenesE80444Cents()
        {
            //Arrange
            ConverteMoedas converter = new ConverteMoedas();
            //Action
            var result = converter.ConverterTester(15.47m, 3);
            //Assert
            Assert.Equal(0.80444m, result);
        }

        [Fact]
        public void Dado354ReaisE53CentsDeveRetornar1595DolaresE385Cents()
        {
            //Arrange
            ConverteMoedas converter = new ConverteMoedas();
            //Action
            var result = converter.ConverterTester(354.53m, 1);
            //Assert
            Assert.Equal(1595.385m, result);
        }

        [Fact]
        public void Dado56ReaisE80CentsDeveRetornar56ReaisE80Cents()
        {
            //Arrange
            ConverteMoedas converter = new ConverteMoedas();
            //Action
            var result = converter.ConverterTester(56.80m, 0);
            //Assert
            Assert.Equal(56.80m, result);
        }

        [Fact]
        public void Dado24ReaisE63CentsDeveRetornar152EurosE706Cents()
        {
            //Arrange
            ConverteMoedas converter = new ConverteMoedas();
            //Action
            var result = converter.ConverterTester(24.63m, 4);
            //Assert
            Assert.Equal(152.706m, result);
        }


    }
}