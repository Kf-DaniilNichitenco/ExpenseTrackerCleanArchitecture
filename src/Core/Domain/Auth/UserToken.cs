﻿using System;
using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.Core.Domain.Auth
{
    public class UserToken : IdentityUserToken<Guid>
    {
    }
}
