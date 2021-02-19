using AppInicial.CORE.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppInicial.Test
{
    public class UsuarioTest : IClassFixture<TestFixture<Startup>>
    {
        private HttpClient Client;

        public UsuarioTest(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task UsuarioTest_LengthUserListOk_Return4()
        {
            var request = new
            {
                Url = "/usuario"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaUsuarios = JsonConvert.DeserializeObject<List<UsuarioDTO>>(value);
            
            // Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaUsuarios.Count == 4);
        }
        [Fact]
        public async Task UsuarioTest_SumTotalSales_Returns96000()
        {
            var request = new
            {
                Url = "/usuario/ventasTotales"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var ventasTotales = JsonConvert.DeserializeObject<int ?>(value);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.True(ventasTotales == 96000);
        }
        [Fact]
        public async Task UsuarioTest_AllUserVentas_ReturnsTrue()
        {
            var request = new
            {
                Url = "/usuario"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaUsuariosVentas = JsonConvert.DeserializeObject<List<UsuarioDTO>>(value);
            Console.WriteLine(listaUsuariosVentas);
            // Assert
            response.EnsureSuccessStatusCode();
            foreach (var u in listaUsuariosVentas)
            {
                Assert.True(u.Rol == "Ventas");

            }
        }
    }


}
