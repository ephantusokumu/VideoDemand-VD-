using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoDemand_VD_.Models;

namespace VideoDemand_VD_.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}