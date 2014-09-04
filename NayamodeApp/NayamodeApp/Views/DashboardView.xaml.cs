using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NayamodeApp.Model;
using NayamodeApp.ViewModels;
using Xamarin.Forms;

namespace NayamodeApp.Views
{
    public partial class DashboardView : CarouselPage
    {
        public DashboardView()
        {
            InitializeComponent();
            AttachHandlers();
            //lstAttendee.BindingContext = new AttendeeViewModel();
            GetData();
        }

        private async void GetData()
        {
            try
            {
                var objService = new NMEventServiceRequest();
                var response = await objService.GetUrlResponse<AttendeeRootobject>(ServiceMethod.URL, "http://gciosummit.nayamodeevents.com/live/attendee.json", "");
                lstAttendee.BindingContext = response;
            }
            catch (Exception ex)
            {

            }
        }

        public async void Tile1_Click()
        {
            await DisplayAlert("Alert", "You have been alerted", "OK", "Cancel");
        }

        public async void AttachHandlers()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.TappedCallback += (sender, e) => Tile1_Click();
            Tile1.GestureRecognizers.Add(tapGestureRecognizer);

        }

        public async void RemoveHandlers()
        {
			Tile1.GestureRecognizers.Clear ();
        }

        
    }
}
