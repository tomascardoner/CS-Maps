﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CSMaps.Models;

public partial class Establecimiento
{
    public short IdEstablecimiento { get; set; }

    public string Nombre { get; set; }

    public short? IdEntidad { get; set; }

    public string TelefonoMovil { get; set; }

    public DateTime UltimaActualizacion { get; set; }

    public virtual Entidad IdEntidadNavigation { get; set; }

    public virtual ICollection<PuntoDato> PuntoDatos { get; set; } = new List<PuntoDato>();
}