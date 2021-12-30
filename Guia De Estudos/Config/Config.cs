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
                    
                    lista.Add(valor.ObterAtributoDoTipo<DescriptionAttribute>().Description);
                    index++;
                }
            }

            return lista;
        }

        public static T ObterAtributoDoTipo<T>(this Enum valorEnum) where T : System.Attribute
        {
            var type = valorEnum.GetType();
            var memInfo = type.GetMember(valorEnum.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

    }
}
