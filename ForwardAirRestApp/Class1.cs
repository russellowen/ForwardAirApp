using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardAirRestApp
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        [JsonProperty("xs:schema")]
        public XsSchema xsschema { get; set; }
    }

    public class XsAnnotation
    {
        [JsonProperty("xs:documentation")]
        public string xsdocumentation { get; set; }
    }

    public class XsComplexType
    {
        [JsonProperty("@name")]
        public string name { get; set; }

        [JsonProperty("xs:sequence")]
        public XsSequence xssequence { get; set; }
    }

    public class XsElement
    {
        [JsonProperty("@name")]
        public string name { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
    }

    public class XsEnumeration
    {
        [JsonProperty("@value")]
        public string value { get; set; }
    }

    public class XsLength
    {
        [JsonProperty("@value")]
        public string value { get; set; }
    }

    public class XsMaxInclusive
    {
        [JsonProperty("@value")]
        public string value { get; set; }
    }

    public class XsMaxLength
    {
        [JsonProperty("@value")]
        public string value { get; set; }
    }

    public class XsMinInclusive
    {
        [JsonProperty("@value")]
        public string value { get; set; }
    }

    public class XsRestriction
    {
        [JsonProperty("@base")]
        public string @base { get; set; }

        [JsonProperty("xs:totalDigits")]
        public XsTotalDigits xstotalDigits { get; set; }

        [JsonProperty("xs:maxLength")]
        public XsMaxLength xsmaxLength { get; set; }

        [JsonProperty("#comment")]
        public List<object> comment { get; set; }

        [JsonProperty("xs:enumeration")]
        public List<XsEnumeration> xsenumeration { get; set; }

        [JsonProperty("xs:maxInclusive")]
        public XsMaxInclusive xsmaxInclusive { get; set; }

        [JsonProperty("xs:minInclusive")]
        public XsMinInclusive xsminInclusive { get; set; }

        [JsonProperty("xs:length")]
        public XsLength xslength { get; set; }
    }

    public class XsSchema
    {
        [JsonProperty("@xmlns:xs")]
        public string xmlnsxs { get; set; }

        [JsonProperty("@xmlns:wmh")]
        public string xmlnswmh { get; set; }

        [JsonProperty("@elementFormDefault")]
        public string elementFormDefault { get; set; }

        [JsonProperty("xs:element")]
        public XsElement xselement { get; set; }

        [JsonProperty("xs:complexType")]
        public List<XsComplexType> xscomplexType { get; set; }

        [JsonProperty("xs:simpleType")]
        public List<XsSimpleType> xssimpleType { get; set; }
    }

    public class XsSequence
    {
        [JsonProperty("xs:element")]
        public object xselement { get; set; }

        [JsonProperty("#comment")]
        public List<object> comment { get; set; }
    }

    public class XsSimpleType
    {
        [JsonProperty("@name")]
        public string name { get; set; }

        [JsonProperty("xs:restriction")]
        public XsRestriction xsrestriction { get; set; }

        [JsonProperty("@final")]
        public string final { get; set; }

        [JsonProperty("xs:annotation")]
        public XsAnnotation xsannotation { get; set; }
    }

    public class XsTotalDigits
    {
        [JsonProperty("@value")]
        public string value { get; set; }
    }


}
