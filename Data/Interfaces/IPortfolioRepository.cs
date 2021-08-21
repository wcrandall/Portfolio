using System.Collections.Generic;
using API.Models;

namespace API.Data.Interfaces
{
    /// <summary>
    /// The interface for PortfolioRepository
    /// </summary>
    public interface IPortfolioRepository
    {
        /// <summary>
        /// Gets all Portfolios
        /// </summary>
        /// <returns>A list of Portfolios</returns>
         IEnumerable<PortfolioDto> GetPortfolios();

         /// <summary>
         /// Gets a Portfolio the mathces the passed in id
         /// </summary>
         /// <param name="id">The id of the Portfolio being searched for</param>
         /// <returns>A Portfolio</returns>
         PortfolioDto GetPortfolio(int id);
    }
}