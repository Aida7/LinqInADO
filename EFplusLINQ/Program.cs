using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFplusLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LinqContext())
            {
               var result= from creator int context.Categories select creator;

                List<Creator> creators = new List<Creator>();
                foreach (var creator in context.Creators.ToList())
                {
                    if (creator.Name.ToLower().Contains("a"))
                    { creator.Add(creator); }
                }

                var anonymResult = from creator in context.Creators
                                   where creator.Name.ToLower().Contains("a")
                                   select new {Title =creator.Name,Text=creator.Description };

                anonymResult.ToList()[0].

                var results= from creator in context.Creators
                            where creator.Name.ToLower().Contains("a") select creator


                var shortResult = context.Creators.Where(creator => creator.Name.ToLower().Contains("a"));

                var singleResult = context.Creators.Single(creator => creator.Name.Contains("qwer"));
                var firstResult = context.Creators.SingleOrDefault(creator => creator.Name.Contains("qwer"));


                //foreach (var creator in result)
                //{
                //    Console.WriteLine(creator.Name);
                //}
                //Console.ReadLine();
            }
            
        }
    }
}
