﻿using ReportingService.Persistence.Entities;

namespace ReportingService.Persistence.Repositories.Interfaces
{

    public interface ITransactionRepository : IBaseRepository<Transaction>
    {
        Task AddTransactionRawSqlAsync(Transaction transaction);
    }
}
