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

            
            var xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
                <FAQuoteRequest><BillToCustomerNumber>2953216</BillToCustomerNumber><ShipperCustomerNumber>2953216</ShipperCustomerNumber><Origin><OriginAirportCode></OriginAirportCode><OriginZipCode>79510</OriginZipCode><Pickup><AirportPickup>N</AirportPickup><PickupAccessorials></PickupAccessorials></Pickup>
                    </Origin><Destination><DestinationAirportCode></DestinationAirportCode><DestinationZipCode>02043</DestinationZipCode><Delivery><AirportDelivery>N</AirportDelivery><DeliveryAccessorials></DeliveryAccessorials></Delivery>
  </Destination><FreightDetails><FreightDetail><FreightClass>1</FreightClass><Description>shoes</Description><Pieces>1</Pieces><Weight>2</Weight><WeightType>L</WeightType></FreightDetail> 
 </FreightDetails>
 <Hazmat>N</Hazmat><InBondShipment>N</InBondShipment><DeclaredValue></DeclaredValue><ShippingDate>2023-05-31</ShippingDate></FAQuoteRequest>";

            try
            {
                var content = new StringContent(xml, Encoding.UTF8, "text/xml");
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
    }
}