﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonAppClient.Interface
{
    public interface IPokemonClient
    {
        public Task<HttpResponseMessage> GetCountriesAsync();
        public Task<HttpResponseMessage> GetCountriesById( int id);

    }
}
