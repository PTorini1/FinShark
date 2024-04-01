using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;
using api.Repository;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock> DeleteAsync(int id);
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> UpdateAsync(int id, UpdateStockRequestDto stockDto);
    }
}