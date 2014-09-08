using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NayamodeApp.Model;
using Newtonsoft.Json;

namespace NayamodeApp.ViewModels
{
    public class AttendeeViewModel
    {
        public ObservableCollection<AttendeeModel> Attendees { get; set; }

        public AttendeeViewModel()
        {
            Attendees = new ObservableCollection<AttendeeModel>();
            
            //Attendees = JsonConvert.DeserializeObject<ObservableCollection<AttendeeModel>>("[{\"Id\":\"c3930e5a-8bc5-4d23-b8b4-d1e791c97789\",\"Name\":\"Martin Ackermann\",\"First\":\"Martin\",\"Last\":\"Ackermann\",\"Company\":\"Heraeus Holding GmbH\",\"IsMicrosoft\":false,\"IsCEO\":false,\"Title\":\"Chief Information Officer\",\"Biography\":\"<p>Martin Ackermann is CIO of Heraeus Holding GmbH, an engineering group based in Hanau, Germany. He also serves as Chief Executive Officer of Heraeus GmbH Infosystems. Ackermann joined Heraeus in 2005 and is responsible for the strategic and operational IT, and process management of the Heraeus Group worldwide at more than 120 locations. Prior to joining Heraeus, Ackermann held various IT positions of increasing responsibility at B. Braun Melsungen AG, a German medical and pharmaceutical company with offices and facilities in 50 countries. There, he ultimately rose to Vice President and Global Project Manager.</p>\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1401916/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"419ee696-6ccb-4cf9-b025-c81692c1dc58\",\"Name\":\"Mary Carol Alexander\",\"First\":\"Mary Carol\",\"Last\":\"Alexander\",\"Company\":\"Microsoft\",\"IsMicrosoft\":true,\"IsCEO\":false,\"Title\":\"District GM, EPG Greater SE\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1554460/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"d2a915c7-51d4-4bee-86a6-38ccd375f838\",\"Name\":\"Chris Altchek\",\"First\":\"Chris\",\"Last\":\"Altchek\",\"Company\":\"Mic \",\"IsMicrosoft\":false,\"IsCEO\":false,\"Title\":\"Co-Founder, Chief Executive Officer\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1553769/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"ba344799-fec4-4e6d-b280-ae9faa6ff8f0\",\"Name\":\"Judson Althoff\",\"First\":\"Judson\",\"Last\":\"Althoff\",\"Company\":\"Microsoft North America\",\"IsMicrosoft\":true,\"IsCEO\":false,\"Title\":\"President\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1561109/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"d3978db9-693e-4194-8d06-d42b9afcf78b\",\"Name\":\"Alberto (Tito) Arciniega\",\"First\":\"Alberto (Tito)\",\"Last\":\"Arciniega\",\"Company\":\"Microsoft Corporation\",\"IsMicrosoft\":true,\"IsCEO\":false,\"Title\":\"Vide President, WW Industry and Global Accounts\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1552089/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"8ba9fbef-a2c2-428d-8f8d-d000f1d11b9e\",\"Name\":\"Tanawong Areeratchakul\",\"First\":\"Tanawong\",\"Last\":\"Areeratchakul\",\"Company\":\"Siam Cement Public Company Limited\",\"IsMicrosoft\":false,\"IsCEO\":false,\"Title\":\"Vice President-Corporate Adminisration\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1496242/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"0b9f72bf-361b-432f-8b19-3783863349ab\",\"Name\":\"Ramon Baez\",\"First\":\"Ramon\",\"Last\":\"Baez\",\"Company\":\"Hewlett-Packard\",\"IsMicrosoft\":false,\"IsCEO\":false,\"Title\":\"Senior Vice President, Global Chief Information Officer\",\"Biography\":\"<p>Ramon Baez serves as the Senior Vice President and CIO of HP, responsible for the global information technology (IT) strategy and all of the company's IT assets that support HP employees and help drive strategic company priorities. This includes worldwide application development, the companyâ€™s private cloud, IT security, data management, technology infrastructure, and telecommunication networks.</p>\n\n<p>Prior to HP, Baez was Vice President of information technology services and CIO of Kimberly-Clark Corp., where he was responsible for leading the companyâ€™s enterprise-wide information systems initiatives. Before Kimberly-Clark, Baez served in CIO roles for Thermo Fisher Scientific, Inc. and Honeywellâ€™s Automation and Control Solution group. He began his career at Northrop Grumman, where he spent 25 years and finished as CIO for its electronics systems sensor sector. </p>\n\n<p>Baezâ€™s career spans more than three decades with global Fortune 100 companies in industries including manufacturing, packaged goods, aerospace and defense, and products and services for the scientific community.</p>\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1401918/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"ca659698-e07f-425f-b3dd-89c41f2680b5\",\"Name\":\"Joe  Barker\",\"First\":\"Joe \",\"Last\":\"Barker\",\"Company\":\"Macquarie Group\",\"IsMicrosoft\":false,\"IsCEO\":false,\"Title\":\"Chief Information Officer\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1482175/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"ade42002-01fe-4710-90e2-b986f39a94ae\",\"Name\":\"Brad Bell\",\"First\":\"Brad\",\"Last\":\"Bell\",\"Company\":\"Microsoft\",\"IsMicrosoft\":true,\"IsCEO\":false,\"Title\":\"GM Infrastructure\",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1554243/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false},{\"Id\":\"d34d9005-3421-49ae-9ace-6fd90e46dea9\",\"Name\":\"Jean-FranÃ§ois Bernard\",\"First\":\"Jean-FranÃ§ois\",\"Last\":\"Bernard\",\"Company\":\"Pernod Ricard\",\"IsMicrosoft\":false,\"IsCEO\":false,\"Title\":\"Group Chief Technology Officer \",\"Biography\":\"\",\"Type\":\"Attendee\",\"Photo\":\"https://eventcore.blob.core.windows.net/10100avatar/r/1478581/normal.png\",\"SessionIds\":[],\"IsSpeaker\":false}]");
            GetData();
        }

        private async void GetData()
        {
            try
            {
                var objService = new NMEventServiceRequest();
                var response =
                    await
                        objService.GetUrlResponse<AttendeeRootobject>(ServiceMethod.URL,
                            "http://gciosummit.nayamodeevents.com/live/attendee.json", "");
                Attendees = response.Data;
            }
            catch (Exception ex)
            {

            }
        }


    }
}
