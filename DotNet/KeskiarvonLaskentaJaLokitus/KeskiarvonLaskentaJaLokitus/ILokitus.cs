using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiarvonLaskentaJaLokitus
{
    public interface ILokitus
    {
        public void Lokita(string viesti);
    }
}
