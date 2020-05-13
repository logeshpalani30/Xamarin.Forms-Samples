using System;
using System.Collections.Generic;
using System.Text;
using vMonitor.Models;

namespace vMonitor.Services
{
    public class HomeServices
    {
        public List<Model> GetHomeList()
        {
            var list = new List<Model>()
            {
                new Model()
                {
                    Name = "Logesh",
                    UserID = 01
                },
                new Model()
                {
                    Name = "Anbu",
                    UserID = 02
                },
                new Model()
                {
                    Name = "Hari",
                    UserID = 03
                },
                new Model()
                {
                    Name = "Guna",
                    UserID = 001
                },

            };
            return list;
        }

    }
}
