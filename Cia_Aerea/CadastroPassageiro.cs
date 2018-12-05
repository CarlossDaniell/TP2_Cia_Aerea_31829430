using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cia_Aerea
{
    class CadastroPassageiro


    {
        public long CPF { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
        public int NPassagem { get; set; }
        public int NPoltrona { get; set; }
        public Voo NVoo { get; set; }
    }
}
