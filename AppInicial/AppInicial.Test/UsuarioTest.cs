using AppInicial.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
            var listaUsuarios = JsonSerializer.Deserialize<List<UsuarioDTO>>(value);
            
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
            var ventasTotales = JsonSerializer.Deserialize<int?>(value);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.True(ventasTotales == 96000);
        }
    }
}
