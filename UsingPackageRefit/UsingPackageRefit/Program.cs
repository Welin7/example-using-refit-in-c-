using Refit;
using System;
using System.Threading.Tasks;

namespace UsingPackageRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var zipcodeClient = RestService.For<IZipcodeApiService>("http://viacep.com.br");
                Console.WriteLine("Inform your postal code:");
                string zipcodeInform = Console.ReadLine().ToString();
                Console.WriteLine("consulting zip code information:" + zipcodeInform);

                var response = await zipcodeClient.GetAddressAsync(zipcodeInform);
                Console.WriteLine($"\nPublicplace:{response.Logradouro}\nComplement:{response.Complemento}\nDistrict:{response.Bairro}\nLocation:{response.Localidade}\nState:{response.Uf}\nZipCode:{response.Cep}\nIBGE:{response.Ibge}\nGIA:{response.Gia}");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error on query of Zipcode: " + e.Message);
            }
        }
    }
}
