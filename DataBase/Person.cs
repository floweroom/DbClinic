using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClinic.DataBase
{
    internal class Person
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? PersonalData { get; set; }

        public string? AnamnesisDesise { get; set; }

        public string? AnamnesisLife { get; set; }

        public bool ObjectStatus { get; set; }

        public string? PlanSurvey { get; set; }

        public string? PlanTherapy { get; set; }

        public string? Recomendation { get; set; }
    }


}
