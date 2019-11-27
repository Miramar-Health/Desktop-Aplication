using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miramar_cheers_1.classes
{
    public static class UserLoginCache
    {
        //nome,email,corem,situação
        public static string Nome_Tecnico { get; set; }
        public static string Email_Tecnico { get; set; }

        public static string Coren_Tecnico { get; set; }

        public static bool Situacao_Tecnico { get; set; }
    }
}
