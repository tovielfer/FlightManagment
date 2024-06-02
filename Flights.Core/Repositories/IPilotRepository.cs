﻿using FlightManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Core.Repositories
{
    public interface IPilotRepository
    {
        public IEnumerable<Pilot> Get();
        public Pilot Get(int id);
        public Task<Pilot> PostAsync(Pilot p);
        public Task<Pilot> PutAsync(int id, Pilot p);
    }
}