using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Log
/// </summary>
public class Log
{
    private string email;
    private string senha;

    public Log(string email, string senha)
    {
        this.email = email;
        this.senha = senha;
    }


    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public string Senha
    {
        get
        {
            return senha;
        }

        set
        {
            senha = value;
        }
    }
}