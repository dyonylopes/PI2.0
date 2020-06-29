using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ReservaBD
/// </summary>
public class ReservaBD
{
    private static int cont = 0;
    private static Reserva[] res = new Reserva[50];

    public static void Insert(Reserva r)
    {
        res[cont] = r;
        cont++;
    }
    public static string SelectTabela()
    {
        string str = "";
        for (int i = 0; i < cont; i++)
        {
            str += "<tr>";
            str += "<td>" + res[i].Nomereserva + "</td>";
            str += "<td>" + res[i].Sobrenome + "</td>";
            str += "<td>" + res[i].Adultos + "</td>";
            str += "<td>" + res[i].Criancas + "</td>";
            str += "<td>" + res[i].Data + "</td>";
            str += "</tr>";
        }

        return str;
    }
}