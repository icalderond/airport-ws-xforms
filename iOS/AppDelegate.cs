using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace airports_country.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            var soapService = new airports_country.iOS.Service.SoapService();
            var serviaAir = new airports_country.Model.ServiceAeropuerto(soapService);

            LoadApplication(new App(serviaAir));

            return base.FinishedLaunching(app, options);
        }
    }
}
