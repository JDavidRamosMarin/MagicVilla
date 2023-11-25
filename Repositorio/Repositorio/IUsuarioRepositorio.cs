using MagicVilla.Modelos;
using MagicVilla.Modelos.DTOs;

namespace MagicVilla.Repositorio.Repositorio
{
    public interface IUsuarioRepositorio
    {
        bool IsUsuarioUnico(string userName);

        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        
        Task<Usuario> Registro(RegistroRequestDTO registroRequestDTO);
    }
}
