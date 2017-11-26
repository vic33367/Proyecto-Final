using System.Threading.Tasks;

namespace Proyecto_Final
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }
}
