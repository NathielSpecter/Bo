using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;

namespace Bo
{
    [Activity(Label = "Bo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        public BoletimService boletim = new BoletimService();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);


            button.Click += async delegate {
                var response = await boletim.GET("TOKEN", 1, 2, 3);
                if(response.IsSuccessStatusCode)
                {
                    //var result = JsonConvert.DeserializeObject<SuaProperty>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                  
                }
            };

            
        }

    }
}

