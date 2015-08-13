using DemoApp.Linq2DbRepository.DataContext;
using DemoApp.Linq2DbRepository.Repository;
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

            //ITrackRepository repoTrack = new TrackRepository(new DatabaseContext());

            //var data = repoTrack.GetAll();

            //Console.WriteLine(data.Count());
            //Console.ReadKey();

            CategoryRepository repo = new CategoryRepository(new DatabaseContext());
            var data = repo.GetAll();
            Console.WriteLine(data.Count());
            Console.ReadKey();

        }
    }
}
