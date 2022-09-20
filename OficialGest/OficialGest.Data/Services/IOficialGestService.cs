using System;
using OficialGest.Models;

namespace OficialGest.Data.Services
{
    public interface IOficialGestService
    {

        Task<IEnumerable<DocUnidad>> GetDocUnidad();
        Task<DocUnidad> GetDocUnidad(int id);
        Task<bool> InsertDocUnidad(DocUnidad docunidad);
        Task<bool> UpdateDocUnidad(DocUnidad docunidad);
        Task<bool> DeleteDocUnidad(DocUnidad docunidad);

        Task<IEnumerable<TipoDoc>> GetTipoDoc();
        Task<TipoDoc> GetTipoDoc(int id);
        Task<bool> InsertTipoDoc(TipoDoc tipodoc);
        Task<bool> UpdateTipoDoc(TipoDoc tipodoc);
        Task<bool> DeleteTipoDoc(TipoDoc tipodoc);

        Task<IEnumerable<Unidad>> GetUnidad();
        Task<Unidad> GetUnidad(int id);
        Task<bool> InsertUnidad(Unidad unidad);
        Task<bool> UpdateUnidad(Unidad unidad);
        Task<bool> DeleteUnidad(Unidad unidad);

        Task<IEnumerable<Usuario>> GetUsuario();
        Task<Usuario> GetUsuario(int id);
        Task<bool> InsertUsuario(Usuario unidad);
        Task<bool> UpdateUsuario(Usuario unidad);
        Task<bool> DeleteUsuario(Usuario unidad);

        Task<IEnumerable<UsuarioUnidad>> GetUsuarioUnidad();
        Task<UsuarioUnidad> GetUsuarioUnidad(int id);
        Task<bool> InsertUsuarioUnidad(UsuarioUnidad usuariounidad);
        Task<bool> UpdateUsuarioUnidad(UsuarioUnidad usuariounidad);
        Task<bool> DeleteUsuarioUnidad(UsuarioUnidad usuariounidad);

    }
}

