using System.Collections.Generic;
using Vidly3.Models;

namespace Vidly3.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}