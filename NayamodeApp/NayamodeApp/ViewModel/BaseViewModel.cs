using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NayamodeApp.ViewModel
{
    public class BaseViewModel<T> where T : class
    {

        #region Speaker Section

        protected async List<T> GetSpeaker()
        {
            try
            {
                var objService = new NMEventServiceRequest();
                var response =
                    await
                        objService.GetUrlResponse<AttendeeRootobject>(ServiceMethod.Get,
                            "http://gciosummit.nayamodeevents.com/live/attendee.json", "");
                Attendees = response.Data;
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

    }
}
