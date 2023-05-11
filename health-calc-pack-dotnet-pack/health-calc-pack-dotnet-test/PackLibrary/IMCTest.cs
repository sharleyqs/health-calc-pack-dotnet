using health_calc_pack_dotnet_pack;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
     
        [Fact]
        public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {
            //Arrange
            iimc imc = new IMC();
            double Height = 1.70;
            double Weight = 88.3;
            double ExpectedIMC = 30.55;

            //Act
            var result -imc.Calc(Height, Weight);


            //Asserts
            Assert.Equal(ExpectedIMC, result)

        }
    }
}