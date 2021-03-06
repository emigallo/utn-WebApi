using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CalculatorWeb.Models;
using Newtonsoft.Json;

namespace CalculatorWeb.Connection
{
    public class RestConnection
    {
        private HttpClient _httpClient;
        private string _baseUri;

        public RestConnection(string baseUri)
        {
            this._httpClient = new HttpClient();
            this._baseUri = baseUri;
        }

        public async Task<T> GetAsync<T>(string partialUri)
        {
            // baseUri: http://localhost:5500
            // partialUri: calc

            string fullUri = string.Format("{0}/{1}", this._baseUri, partialUri);

            HttpResponseMessage response = await this._httpClient.GetAsync(fullUri);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Ocurrió un error al hacer el llamado a la API");
            }

            string content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(content);
        }


        //private List<UserModel> GetFromSql()
        //{
        //    SqlCommand sqlCommand = new SqlCommand(sqlConnection, "SELECT * FROM Users WHERE Id > 3");

        //    SqlDataReader reader = sqlCommand.ExecuteReader();

        //    List<UserModel> rett = new List<UserModel>();
        //    while (reader.Read())
        //    {
        //        rett.Add(new UserModel()
        //        {
        //            Name = reader.GetString("Name"),
        //            Email = reader.GetString("Email")
        //        });
        //    }

        //     //rett.Where(x => x.Name == "Emiliano");
        //    return rett;
        //}
    }
}