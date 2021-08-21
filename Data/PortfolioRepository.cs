using System.Collections.Generic;
using System.Linq;
using API.Data.Interfaces;
using API.Models;

namespace API.Data
{
    /// <summary>
    /// Implements <see cref="IPortfolioRepository"/>
    /// </summary>
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly IList<PortfolioDto> portfolios = new List<PortfolioDto>(){
            new PortfolioDto{
                Id = 0,
                FirstName = "John",
                LastName = "Smith"
            },
            new PortfolioDto{
                Id = 1, 
                FirstName = "Tom",
                LastName = "Hanson"
            },
            new PortfolioDto{
                Id = 2, 
                FirstName = "Tim", 
                LastName = "Scott"
            }
        };

        /// <inheritdoc cref="IPortfolioRepository.GetPortfolioDto(int)"/>

        public PortfolioDto GetPortfolio(int id)
        {
            return this.portfolios.FirstOrDefault(portfolio => portfolio.Id == id);
        }

        /// <inheritdoc cref="IPortfolioRepository.GetPortfolios()"/>
        public IEnumerable<PortfolioDto> GetPortfolios()
        {
            return portfolios;
        }
    }
}