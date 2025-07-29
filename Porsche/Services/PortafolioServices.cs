using Porsche.DTOs;
using Porsche.Interfaces;
namespace Porsche.Services
{
    public class PortafolioServices : PortafolioInterface
    {
        public String? UrlImg;
        public PortafolioServices()
        {
            UrlImg = "https://e7.pngegg.com/pngimages/21/228/png-clipart-computer-icons-user-profile-others-miscellaneous-face.png";
        }

        public PortafolioDTO GetPortafolio()
        {
            PortafolioDTO portafolioObj = new PortafolioDTO();
            portafolioObj.NombreMateria = "Ingenieria De Software";
            portafolioObj.Curso = "Lab: 1 JOBS";
            portafolioObj.Horario = "10:45 A 21:00 Lunes Y Miércoles";
            portafolioObj.Profesor = "Pablo Backgardigans";
            portafolioObj.Title = "Ordinario 1 2025 LAS AGUAS";
            portafolioObj.Aula = "01";
            portafolioObj.Img = "";
            return portafolioObj;
        }
    }
}
