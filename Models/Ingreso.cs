﻿using System;
using System.Collections.Generic;

namespace MyFi.Models
{
    public partial class Ingreso
    {
        public int Id_Ingresos { get; set; }
        public int? Id { get; set; }
        public float Monto { get; set; }
        public int? Tipo { get; set; }
        public DateOnly? Fecha { get; set; }
        public bool? Notificacion { get; set; }
        public bool? Automatico { get; set; }
        public bool Recurrencia { get; set; }

        public virtual Usuario? IdNavigation { get; set; }
        public virtual TipoIngreso? TipoIngreso { get; set; }
    }
}
