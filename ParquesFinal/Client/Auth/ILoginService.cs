﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParquesFinal.Client.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }   
}
