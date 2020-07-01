using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Reserva
/// </summary>
public class Reserva
{
    private string nomereserva;
    private string sobrenome;
    private int adultos;
    private int criancas;
    private DateTime data;

    public Reserva(string nomereserva, string sobrenome, int adultos, int criancas, DateTime data)
    {
        this.Nomereserva = nomereserva;
        this.Sobrenome = sobrenome;
        this.Adultos = adultos;
        this.Criancas = criancas;
        this.data = data;

    }

    public string Nomereserva
    {
        get
        {
            return nomereserva;
        }

        set
        {
            nomereserva = value;
        }
    }

    public string Sobrenome
    {
        get
        {
            return sobrenome;
        }

        set
        {
            sobrenome = value;
        }
    }

    public int Adultos
    {
        get
        {
            return adultos;
        }

        set
        {
            adultos = value;
        }
    }

    public int Criancas
    {
        get
        {
            return criancas;
        }

        set
        {
            criancas = value;
        }
    }

    public DateTime Data
    {
        get
        {
            return data;
        }

        set
        {
            data = value;
        }
    }
}

   