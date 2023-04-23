using ForwardAirApp.FastQuoteService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ForwardAirApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

          
            var fastQuoteService = new FastQuoteService.FastQuoteServiceClient();
            
            var result = fastQuoteService.getQuote("highddfw", "G6rgDBI6rcg0WgSa", "HIGHDDFW", @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:web=""http://webservices.shipmentbooking.forwardair.com/"">
 <soapenv:Header/>
 <soapenv:Body>
 <web:getQuote>
  <user>highddfw</user>
 <password>G6rgDBI6rcg0WgSa</password>
 <customerId>HIGHDDFW</customerId>
 <quoteRequest><![CDATA[<?xml version=""1.0"" encoding=""utf-8""?><FAQuoteRequest><BillToCustomerNumber>2953216</BillToCustomerNumber><ShipperCustomerNumber>2953216</ShipperCustomerNumber><Origin><OriginAirportCode></OriginAirportCode><OriginZipCode>79510</OriginZipCode><Pickup><AirportPickup>N</AirportPickup><PickupAccessorials></PickupAccessorials></Pickup>
                    </Origin><Destination><DestinationAirportCode></DestinationAirportCode><DestinationZipCode>02043</DestinationZipCode><Delivery><AirportDelivery>N</AirportDelivery><DeliveryAccessorials></DeliveryAccessorials></Delivery>
  </Destination><FreightDetails><FreightDetail><FreightClass>1</FreightClass><Description>shoes</Description><Pieces>1</Pieces><Weight>2</Weight><WeightType>L</WeightType></FreightDetail> 
 </FreightDetails>
 <Hazmat>N</Hazmat><InBondShipment>N</InBondShipment><DeclaredValue></DeclaredValue><ShippingDate>2023-05-31</ShippingDate></FAQuoteRequest>]]>
 
</quoteRequest>
</web:getQuote>
</soapenv:Body>
</soapenv:Envelope>");
        }
    }
}
