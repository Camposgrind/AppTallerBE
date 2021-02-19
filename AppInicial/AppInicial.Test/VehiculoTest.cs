using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using AppInicial.CORE.DTO;
using Newtonsoft.Json;

namespace AppInicial.Test
{
    public class VehiculoTest : IClassFixture<TestFixture<Startup>>
    {
        private HttpClient Client;

        public VehiculoTest(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task VehiculoTest_LengthVehiclesSoldListOk_Return3()
        {
            var request = new
            {
                Url = "/vehiculo"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaVehiculosVendidos = JsonConvert.DeserializeObject<List<VehiculoDTO>>(value);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaVehiculosVendidos.Count == 3);
        }
        [Fact]
        public async Task VehiculoTest_AllVehiclesAreSold_ReturnsTrue()
        {
            var request = new
            {
                Url = "/vehiculo"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaVehiculosVendidos = JsonConvert.DeserializeObject<List<VehiculoDTO>>(value);
            Console.WriteLine(listaVehiculosVendidos);
            // Assert
            response.EnsureSuccessStatusCode();
            foreach(var v in listaVehiculosVendidos){
                Assert.True(v.Vendido == 1);

            }
        }
        [Fact]
        public async Task VehiculoTest_LengthVehiclesStockListOk_Return4()
        {
            var request = new
            {
                Url = "/vehiculo/stock"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaVehiculosStock = JsonConvert.DeserializeObject<List<VehiculoDTO>>(value);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaVehiculosStock.Count == 3);
        }
        [Fact]
        public async Task VehiculoTest_AllVehiclesAreinStock_ReturnsTrue()
        {
            var request = new
            {
                Url = "/vehiculo/Stock"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaVehiculosVendidos = JsonConvert.DeserializeObject<List<VehiculoDTO>>(value);
            Console.WriteLine(listaVehiculosVendidos);
            // Assert
            response.EnsureSuccessStatusCode();
            foreach (var v in listaVehiculosVendidos)
            {
                Assert.True(v.Vendido == 0);

            }
        }

    }
}
