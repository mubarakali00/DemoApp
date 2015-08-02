using DemoApp.EfRepository.Context;
using DemoApp.EfRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            ITrackRepository repoTrack = new TrackRepository(new DatabaseContext());

            var data = repoTrack.GetAll();

            Console.WriteLine(data.Count());
            Console.ReadKey();
        }
    }
}
