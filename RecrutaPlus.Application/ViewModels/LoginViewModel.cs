﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecrutaPlus.Application.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Código")]
        public int usuarioId { get; set; }

        [Display(Name = "Nome do Usuário")]
        public string username { get; set; }

        [Display(Name = "Senha")]
        public string password { get; set; }

        //Default
        public DateTime Cadastro { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime Edicao { get; set; }
        public string EditadoPor { get; set; }
        public long VersionStamp { get; set; } //public byte[]? VersionStamp { get; set; }
        public Guid GuidStamp { get; set; }

        [JsonIgnore]
        public virtual IList<EmployeeViewModel> Employees { get; set; }

    }
}
