using ForwardAirQuoteRequestSchemaV2;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ForwardAirRestApp
{
    public partial class Form1 : Form
    {
        static HttpClient client = new();
        public Form1()
        {
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip,deflate");
            client.DefaultRequestHeaders.Add("user", "highddfw");
            client.DefaultRequestHeaders.Add("password", "G6rgDBI6rcg0WgSa");
            client.DefaultRequestHeaders.Add("customerId", "HIGHDDFW");
           // client.DefaultRequestHeaders.Add("Content-Type", "application/xml");
            client.DefaultRequestHeaders.Add("User-Agent","Jakarta Commons-HttpClient/3.1");
            client.DefaultRequestHeaders.Add("Host", "api.forwardair.com");


            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ProcessRequestAsync(client).GetAwaiter().GetResult();
        }
        static async Task<int> ProcessRequestAsync(HttpClient client)
        {

            var request = new FAQuoteRequest();

            
            request.BillToCustomerNumber = Convert.ToString(2953216);
            request.ShipperCustomerNumber = Convert.ToString(2953216);
            request.Origin = new Origin
            {
                OriginZipCode = "79510"
            };
            request.Destination = new Destination
            {
                DestinationZipCode = "02043",
                Delivery = new Delivery
                {
                    AirportDelivery = YNType.N
                }
            };
            var freightDetails = new List<FreightDetail>();
            freightDetails.Add(new FreightDetail
            {
                FreightClass = 1,
                Description = "shoes",
                Pieces = "1",
                Weight = 2,
                WeightType = WeightUnitType.L,

            });
            request.FreightDetails = freightDetails.ToArray();
            request.Hazmat = YNType.N;
            request.InBondShipment = YNType.N;
            request.ShippingDate = new DateTime(2023, 5, 31);

            request.DeclaredValue = 0;

            var xmlObj = ToXML(request);







            var xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
                <FAQuoteRequest><BillToCustomerNumber>2953216</BillToCustomerNumber><ShipperCustomerNumber>2953216</ShipperCustomerNumber><Origin><OriginAirportCode></OriginAirportCode><OriginZipCode>79510</OriginZipCode><Pickup><AirportPickup>N</AirportPickup><PickupAccessorials></PickupAccessorials></Pickup>
                    </Origin><Destination><DestinationAirportCode></DestinationAirportCode><DestinationZipCode>02043</DestinationZipCode><Delivery><AirportDelivery>N</AirportDelivery><DeliveryAccessorials></DeliveryAccessorials></Delivery>
  </Destination><FreightDetails><FreightDetail><FreightClass>1</FreightClass><Description>shoes</Description><Pieces>1</Pieces><Weight>2</Weight><WeightType>L</WeightType></FreightDetail> 
 </FreightDetails>
 <Hazmat>N</Hazmat><InBondShipment>N</InBondShipment><DeclaredValue></DeclaredValue><ShippingDate>2023-05-31</ShippingDate></FAQuoteRequest>";

            try
            {
                var content = new StringContent(xmlObj, Encoding.UTF8, "text/xml");
                var response = client.PostAsync("https://api.forwardair.com/ltlservices/v2/rest/waybills/quote", content).GetAwaiter().GetResult();
                var result = response.Content.ReadAsStringAsync();
                
                var xmlSerializer = new XmlSerializer(typeof(FAQuoteResponse));
                using (StringReader sr = new StringReader(result.Result)){
                var obj = xmlSerializer.Deserialize(sr);
                }
            }
            catch(Exception e){
            
            }
            return 1;
            
        }
        public static string ToXML(Object oObject)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(oObject.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, oObject);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml.Replace($"xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
            }
        }
    }
}