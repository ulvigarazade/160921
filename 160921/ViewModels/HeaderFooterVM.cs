using _160921.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _160921.ViewModels
{
    public class HeaderFooterVM
    {
        public Data Data { get; set; }
        public IEnumerable<CenterPhoneNumber> CenterPhoneNumbers { get; set; }
    }
}
