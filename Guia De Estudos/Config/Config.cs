using EnumsNET;
using Guia_De_Estudos.Model.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Guia_De_Estudos.Config
{
    public static class Global
    {
        public static IList Listar(Type tipo)
        {
            ArrayList lista = new ArrayList();
            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);
                var index = 0;
                foreach (Enum valor in enumValores)
                {
                    
                    lista.Add(Enum.GetName(tipo, Enum.GetValues(tipo).GetValue(index)));
                    index++;
                }
            }

            return lista;
        }

    }
}
