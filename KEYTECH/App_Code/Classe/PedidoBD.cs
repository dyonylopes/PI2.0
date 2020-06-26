using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PedidoBD
/// </summary>
public class PedidoBD
{
    private static int cont = 0;
    private static Pedido[] ped = new Pedido[50];

    public static void Insert(Pedido p)
    {
        ped[cont] = p;
        cont++;
    }
    public static string SelectTabela()
    {
        string str = "";
        for (int i = 0; i < cont; i++)
        {
            str += "<tr>";
            str += "<td>" + ped[i].Prato + "</td>";
            str += "<td>" + ped[i].Rua + "</td>";
            str += "<td>" + ped[i].Numero + "</td>";
            str += "<td>" + ped[i].Bairro + "</td>";
            str += "</tr>";
        }

        return str;
    }
}