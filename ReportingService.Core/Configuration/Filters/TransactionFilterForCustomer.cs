﻿namespace ReportingService.Core.Configuration.Filters;

public class TransactionFilterForCustomer
{
    public required int TransactionsCount { get; set; }
    public required DateFilter DateFilter { get; set; }
}
