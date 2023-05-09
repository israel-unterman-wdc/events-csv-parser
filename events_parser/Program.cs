using System;
using System.Collections.Generic;
using System.Linq;

namespace events_parser
{
   class Program
   {
      static void Main(string[] args)
      {
         // parse command line as key-value pairs only
         int[] ar = { 1, 2, 3 };
         var cmdparams = args.ToDictionary();
      }
   }
}
