﻿using MYPBackendMicroserviceIntegrations.Enums;

namespace ReportingService.Persistence.Entities;

public class Account
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime DateCreated { get; set; }
    public bool IsDeactivated { get; set; }
    public Currency Currency { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = [];
    public Customer Customer { get; set; }
}
