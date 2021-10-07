using System;
using Starbucks_KahveDunyasi.Interfaces;

namespace Starbucks_KahveDunyasi.Individuals
{
    public class Customers : IIndividuals
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthData { get; set; }
        public long NationalityId { get; set; }
    }
}