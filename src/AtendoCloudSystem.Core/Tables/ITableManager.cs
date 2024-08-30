﻿using Abp.Domain.Services;
using AtendoCloudSystem.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendoCloudSystem.Tables
{
    public interface ITableManager : IDomainService
    {
        Task<Table> GetAsync(Guid id);

        Task CreateAsync(Table @table);

        void Cancel(Table @table);

        Task<TableRegistration> RegisterAsync(Table @table, User user);

        Task CancelRegistrationAsync(Table @table, User user);

        Task<IReadOnlyList<User>> GetRegisteredUsersAsync(Table @table);
    }
}
