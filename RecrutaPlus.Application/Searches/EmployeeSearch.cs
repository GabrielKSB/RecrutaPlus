﻿using RecrutaPlus.Application.Filters;
using RecrutaPlus.Application.ViewModels;
using RecrutaPlus.Domain.Constants;
using RecrutaPlus.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecrutaPlus.Application.Searches
{
    public class EmployeeSearch
    {
        [JsonIgnore]
        public List<EmployeeViewModel> Itens { get; set; } = new List<EmployeeViewModel>();
        public EmployeeFilterViewModel Filter { get; set; }

        [Display(Name = "Name = Carregar")]
        public bool HasFilter { get; set; } = DefaultConst.FILTER_HASFILTER_DEFAULT;
        public int TakeLast { get; set; } = DefaultConst.FILTER_TAKELAST_DEFAULT_ALL;
        public TakeLastEnum TakeLasts { get; set; }
    }
}
