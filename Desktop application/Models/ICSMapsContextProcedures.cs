﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using CSMaps.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace CSMaps.Models
{
    public partial interface ICSMapsContextProcedures
    {
        Task<List<ObtenerPuntosDatosYEventosResult>> ObtenerPuntosDatosYEventosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}