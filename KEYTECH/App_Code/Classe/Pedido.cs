using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pedido
/// </summary>
public class Pedido
{
    private string prato;
    private string rua;
    private int numero;
    private string bairro;

    public Pedido(string prato, string rua, int numero, string bairro)
    {
        this.prato = prato;
        this.rua = rua;
        this.numero = numero;
        this.bairro = bairro;
    }

    public string Prato
    {
        get
        {
            return prato;
        }

        set
        {
            prato = value;
        }
    }

    public string Rua
    {
        get
        {
            return rua;
        }

        set
        {
            rua = value;
        }
    }

    public int Numero
    {
        get
        {
            return numero;
        }

        set
        {
            numero = value;
        }
    }

    public string Bairro
    {
        get
        {
            return bairro;
        }

        set
        {
            bairro = value;
        }
    }
}