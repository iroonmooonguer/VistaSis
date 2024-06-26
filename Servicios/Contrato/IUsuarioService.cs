﻿using Microsoft.EntityFrameworkCore;
using VistaSis.Models;



namespace VistaSis.Servicios.Contrato
{

    public interface IUsuarioService
    {
       
            Task<Usuario> GetUsuario(string correo, string clave);
            Task<Usuario> SaveUsuario(Usuario modelo);
       
    }
}
