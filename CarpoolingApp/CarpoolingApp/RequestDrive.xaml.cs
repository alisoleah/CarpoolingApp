using Android.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarpoolingApp.map;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CarpoolingApp
{
    public partial class RequestDrive : ContentPage
    {
        public RequestDrive()
        {
            InitializeComponent();
            

            
            var customMap = new CustomMap
            {
                MapType = MapType.Hybrid,
            };

            var position1 = new Position(36.8961, 10.1865);
            var position2 = new Position(36.891, 10.181);
            var position3 = new Position(36.892, 10.182);
            var position4 = new Position(36.893, 10.183);
            var position5 = new Position(36.891, 10.185);
            var position6 = new Position(36.892, 10.187);

            var customPin1 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "IntilaQ",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.intilaq.tn",
            };


            var customPin2 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position2,
                    Label = "Telnet R&D",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.groupe-telnet.com"
            };

            var customPin3 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position3,
                    Label = "Kromberg&Schubert",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.kromberg-schubert.com"
            };

            var customPin4 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position4,
                    Label = "Via Mobile",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.kromberg-schubert.com"
            };

            var customPin5 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position5,
                    Label = "Via Mobile",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.kromberg-schubert.com"
            };

            var customPin6 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position6,
                    Label = "Via Mobile",
                    Address = "Technopark Elgazala, Tunisia"
                },
                Url = "www.kromberg-schubert.com"
            };

            customMap.CustomPins = new List<CustomPin>
            {
                customPin1,
                customPin2,
                customPin3,
                customPin4,
                customPin5,
                customPin6,
            };

            var Pin = new Pin
            {
                Type = PinType.SearchResult,
                Position = position6,
                Label = "Via Mobile",
                Address = "Technopark Elgazala, Tunisia"
            };


            customMap.Pins.Add(Pin);
            //CustomPin p = new CustomPin();
            //p.Pin();
            //customMap.CustomPins();
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Position(36.8961, 10.1865), Distance.FromMiles(0.5)));

            Content = customMap;
           // MainMap = customMap;
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(
        //        new Position(36.8961, 10.1865),
        //        Distance.FromMiles(0.5)));
        //}
    }
}
