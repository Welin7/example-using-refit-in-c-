using Refit;
using System.Threading.Tasks;

namespace UsingPackageRefit
{
    public interface IZipcodeApiService
    {
        [Get("/ws/{zipcode}/json")]
        Task<ZipcodeResponse> GetAddressAsync(string zipcode);
    }
}
