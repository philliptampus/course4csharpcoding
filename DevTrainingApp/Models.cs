using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTrainingApp
{
    public class Cinema
    {
        public Cinema(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<CinemaSeat> CinemaSeats { get; set; } = new List<CinemaSeat>();
    }

    public class CinemaSeat
    {
        public int Id { get; set; }

        public string SeatNumber { get; set; }

        public bool IsTaken { get; set; }
    }
}
