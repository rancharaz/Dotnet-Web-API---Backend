using System;
using System.Collections.Generic; // <--- Used for List<StockDto>
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq; // Required for LINQ methods like .Select() and .ToList()
using System.Linq.Expressions;

namespace api.Mappers;

public static class StockMappers
{
    public static StockDto ToStockDto(this Stock stockModel)
    {
        return new StockDto
        {
            Id = stockModel.Id,
            SymbolDocumentInfo = stockModel.Symbol,
            CompanyName = stockModel.CompanyName,
            Purchane = stockModel.Purchase,
            LastDiv = stockModel.LastDiv,
            Industry = stockModel.Industry,
            MarketCap = stockModel.MarketCap
        };
    }
}
