using Porsche.DTOs;
using Porsche.Interfaces;
namespace Porsche.Services
{
    public class PortafolioServices : PortafolioInterface
    {
        public PortafolioDTO GetPortafolio()
        {
            PortafolioDTO portafolioObj = new PortafolioDTO();
            return portafolioObj;
        }
    }
}
