using health_calc_pack_dotnet_pack.Interfaces;

namespace health_calc_pack_dotnet_pack
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weight)
        {
            return Weight / (Height * Height);
                
        }

        public string GetIMCCategory(double IMC)
        {
            throw new NotImplementedException();
        }

        public bool IsValidData(double Height, double Weight)
        {
            throw new NotImplementedException();
        }
    }
}