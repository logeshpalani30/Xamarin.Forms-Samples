// 16:38
using System;
using System.Collections.Generic;
using XFDataGrid.Models;

namespace XFDataGrid.Utils
{
    public static class DummyProfessionalData
    {
        public static List<Professional> GetProfessionals()
        {
            var data = new List<Professional>();
            var person = new Professional()
            {
                Id = "3",
                Name = "Monkey",
                Desigination = "Developer",
                Domain = "Mobile",
                Experience = "1"
            };

            for (int i = 0; i < 10; i++)
            {
                data.Add(person);

            }
            return data;
        }
    }
}