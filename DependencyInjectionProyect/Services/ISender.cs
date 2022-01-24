using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProyect.Services
{
    public interface ISender
    {
        void Send(Customer customer, string message);      

    }
}
