using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Net.Http;

namespace Bo
{
    public class BoletimService
    {
        private string Url = "https://api.gennera.com.br/service/serie/";
        //https://api.gennera.com.br/service/serie/225704/aluno/13257022/matricula/13257022/nota?ano=2016
        public async Task<HttpResponseMessage> GET(string accessToken, int serie,int alunoId, int matriculaAlnuno)
        {
            var client = new HttpClient();
            Uri url = new Uri(string.Concat(Url, serie,"/aluno/",alunoId,"/matricula/",matriculaAlnuno,"/nota?ano=2016"));
            var response = await client.GetAsync(url);
            return response;
        }
    }
}