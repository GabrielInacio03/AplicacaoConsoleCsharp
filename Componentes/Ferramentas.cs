using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssemble()
        {
            return "Este método só pode ser acessado dentro deste assemble componente";
        }
        public string MetodoParaTodosQueUtilizarOAssemble()
        {
            return "Este método é para todos";
        }
    }
}
