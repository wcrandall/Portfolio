using System.Collections.Generic;
using API.Data;
using API.Data.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    /// Controller for Portfolios
    /// </summary>
    [Route("api/portfolios")]
    [ApiController]
    public class PortfoliosController:ControllerBase
    {
        private readonly IPortfolioRepository portfolioRepository = new PortfolioRepository();
        
        public PortfoliosController(IPortfolioRepository portfolioRepository)
        {
            this.portfolioRepository = portfolioRepository;
        }
        /// <summary>
        /// GET api/portfolios
        /// Gets all Portfolios
        /// </summary>
        /// <returns>All Portfolios</returns>
        [HttpGet]
        public ActionResult<IEnumerable<PortfolioDto>> GetPortfolios(){
            return Ok(this.portfolioRepository.GetPortfolios());
        }

        /// <summary>
        /// GET api/portfolios/id
        /// Gets a single portfolio
        /// </summary>
        /// <param name="id">The id of the Portfolio being searched for</param>
        /// <returns>The Portfolio corresponding to the passed in id</returns>
        [HttpGet("{id}")]
        public ActionResult<PortfolioDto> GetPortfolio(int id){
            return Ok(this.portfolioRepository.GetPortfolio(id));
        }
    }
}