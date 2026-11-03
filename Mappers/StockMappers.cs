using System;
using System.Collections.Generic; // <--- Used for List<StockDto>
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq; // Required for LINQ methods like .Select() and .ToList()
using System.Linq.Expressions;
using api.Dtos.Stock;
using api.Models;
namespace api.Mappers;

public static class StockMappers
{
    public static StockDto ToStockDto(this Stock stockModel)
    {
        return new StockDto
        {
            Id = stockModel.Id,
            Symbol = stockModel.Symbol,
            CompanyName = stockModel.CompanyName,
            Purchase = stockModel.Purchase,
            Industry = stockModel.Industry,
            MarketCap = stockModel.MarketCap
        };
    }
    public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
    {
        return new Stock
        {
            Symbol = stockDto.Symbol,
            CompanyName = stockDto.CompanyName,
            Purchase = stockDto.Purchase,
            Industry = stockDto.Industry,
            MarketCap = stockDto.MarketCap

        };
    }
}
