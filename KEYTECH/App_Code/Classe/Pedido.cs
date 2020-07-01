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
    private int quantidade;
    private double valor;


    public Pedido(string prato, string rua, int numero, string bairro, int quantidade, double valor)
    {
        this.Prato = prato;
        this.Rua = rua;
        this.Numero = numero;
        this.Bairro = bairro;
        this.Quantidade = quantidade;
        this.Valor = valor;
     

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

    public int Quantidade
    {
        get
        {
            return quantidade;
        }

        set
        {
            quantidade = value;
        }
    }

    public double Valor
    {
        get
        {
            return valor;
        }

        set
        {
            valor = value;
        }
    }
    public double Calvalor()
    {

        return quantidade * valor;
    }
}
