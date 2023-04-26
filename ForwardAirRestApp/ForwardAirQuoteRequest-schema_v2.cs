///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 20.3.0                                    //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = False
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = ForwardAirRestApp
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// MixedContentHandling                     = TreatAsAny
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd


namespace ForwardAirRestApp
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("20.3.0.12098", "Trial for Non-Commercial Use Expiry [2023-05-09]", "NFXRGB1P5X4GYLJC", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

}

namespace ForwardAirRestApp.Ns
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type DeliveryAccessorialType</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/simpleType:DeliveryAccessorialType</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>205:2-254:18</XsdLocation>
    [LxSimpleTypeDefinition("DeliveryAccessorialType", "")]
    public enum DeliveryAccessorialTypeEnum
    {
        /// <summary>Represents the value 'ADE' in the XML</summary>
        [LxEnumValue("ADE")]
        ADE,
        /// <summary>Represents the value 'AFD' in the XML</summary>
        [LxEnumValue("AFD")]
        AFD,
        /// <summary>Represents the value 'ALD' in the XML</summary>
        [LxEnumValue("ALD")]
        ALD,
        /// <summary>Represents the value 'CCD' in the XML</summary>
        [LxEnumValue("CCD")]
        CCD,
        /// <summary>Represents the value 'CPD' in the XML</summary>
        [LxEnumValue("CPD")]
        CPD,
        /// <summary>Represents the value 'DR1' in the XML</summary>
        [LxEnumValue("DR1")]
        DR1,
        /// <summary>Represents the value 'DR2' in the XML</summary>
        [LxEnumValue("DR2")]
        DR2,
        /// <summary>Represents the value 'EMD' in the XML</summary>
        [LxEnumValue("EMD")]
        EMD,
        /// <summary>Represents the value 'HDC' in the XML</summary>
        [LxEnumValue("HDC")]
        HDC,
        /// <summary>Represents the value 'HOD' in the XML</summary>
        [LxEnumValue("HOD")]
        HOD,
        /// <summary>Represents the value 'IDE' in the XML</summary>
        [LxEnumValue("IDE")]
        IDE,
        /// <summary>Represents the value 'LGD' in the XML</summary>
        [LxEnumValue("LGD")]
        LGD,
        /// <summary>Represents the value 'MBD' in the XML</summary>
        [LxEnumValue("MBD")]
        MBD,
        /// <summary>Represents the value 'MDC' in the XML</summary>
        [LxEnumValue("MDC")]
        MDC,
        /// <summary>Represents the value 'MOD' in the XML</summary>
        [LxEnumValue("MOD")]
        MOD,
        /// <summary>Represents the value 'PJD' in the XML</summary>
        [LxEnumValue("PJD")]
        PJD,
        /// <summary>Represents the value 'RDE' in the XML</summary>
        [LxEnumValue("RDE")]
        RDE,
        /// <summary>Represents the value 'RDS' in the XML</summary>
        [LxEnumValue("RDS")]
        RDS,
        /// <summary>Represents the value 'THD' in the XML</summary>
        [LxEnumValue("THD")]
        THD,
        /// <summary>Represents the value 'UND' in the XML</summary>
        [LxEnumValue("UND")]
        UND,
        /// <summary>Represents the value 'UNP' in the XML</summary>
        [LxEnumValue("UNP")]
        UNP,
        /// <summary>Represents the value 'WED' in the XML</summary>
        [LxEnumValue("WED")]
        WED,
        /// <summary>Represents the value 'XPD' in the XML</summary>
        [LxEnumValue("XPD")]
        XPD,
    }
    /// <summary>An enumeration representing XSD simple type FreightClassType</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/simpleType:FreightClassType</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>255:2-275:18</XsdLocation>
    [LxSimpleTypeDefinition("FreightClassType", "")]
    public enum FreightClassTypeEnum
    {
        /// <summary>Represents the value '50' in the XML</summary>
        [LxEnumValue("50")]
        N50,
        /// <summary>Represents the value '55' in the XML</summary>
        [LxEnumValue("55")]
        N55,
        /// <summary>Represents the value '60' in the XML</summary>
        [LxEnumValue("60")]
        N60,
        /// <summary>Represents the value '65' in the XML</summary>
        [LxEnumValue("65")]
        N65,
        /// <summary>Represents the value '70' in the XML</summary>
        [LxEnumValue("70")]
        N70,
        /// <summary>Represents the value '77.5' in the XML</summary>
        [LxEnumValue("77.5")]
        N77_5,
        /// <summary>Represents the value '85' in the XML</summary>
        [LxEnumValue("85")]
        N85,
        /// <summary>Represents the value '92.5' in the XML</summary>
        [LxEnumValue("92.5")]
        N92_5,
        /// <summary>Represents the value '100' in the XML</summary>
        [LxEnumValue("100")]
        N100,
        /// <summary>Represents the value '110' in the XML</summary>
        [LxEnumValue("110")]
        N110,
        /// <summary>Represents the value '125' in the XML</summary>
        [LxEnumValue("125")]
        N125,
        /// <summary>Represents the value '150' in the XML</summary>
        [LxEnumValue("150")]
        N150,
        /// <summary>Represents the value '200' in the XML</summary>
        [LxEnumValue("200")]
        N200,
        /// <summary>Represents the value '250' in the XML</summary>
        [LxEnumValue("250")]
        N250,
        /// <summary>Represents the value '300' in the XML</summary>
        [LxEnumValue("300")]
        N300,
        /// <summary>Represents the value '400' in the XML</summary>
        [LxEnumValue("400")]
        N400,
        /// <summary>Represents the value '500' in the XML</summary>
        [LxEnumValue("500")]
        N500,
    }
    /// <summary>An enumeration representing XSD simple type PickupAccessorialType</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/simpleType:PickupAccessorialType</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>161:2-204:18</XsdLocation>
    [LxSimpleTypeDefinition("PickupAccessorialType", "")]
    public enum PickupAccessorialTypeEnum
    {
        /// <summary>Represents the value 'AFP' in the XML</summary>
        [LxEnumValue("AFP")]
        AFP,
        /// <summary>Represents the value 'ALP' in the XML</summary>
        [LxEnumValue("ALP")]
        ALP,
        /// <summary>Represents the value 'APP' in the XML</summary>
        [LxEnumValue("APP")]
        APP,
        /// <summary>Represents the value 'CCF' in the XML</summary>
        [LxEnumValue("CCF")]
        CCF,
        /// <summary>Represents the value 'CCP' in the XML</summary>
        [LxEnumValue("CCP")]
        CCP,
        /// <summary>Represents the value 'CPX' in the XML</summary>
        [LxEnumValue("CPX")]
        CPX,
        /// <summary>Represents the value 'HOT' in the XML</summary>
        [LxEnumValue("HOT")]
        HOT,
        /// <summary>Represents the value 'HPC' in the XML</summary>
        [LxEnumValue("HPC")]
        HPC,
        /// <summary>Represents the value 'IPU' in the XML</summary>
        [LxEnumValue("IPU")]
        IPU,
        /// <summary>Represents the value 'LGP' in the XML</summary>
        [LxEnumValue("LGP")]
        LGP,
        /// <summary>Represents the value 'MBP' in the XML</summary>
        [LxEnumValue("MBP")]
        MBP,
        /// <summary>Represents the value 'MOP' in the XML</summary>
        [LxEnumValue("MOP")]
        MOP,
        /// <summary>Represents the value 'MPC' in the XML</summary>
        [LxEnumValue("MPC")]
        MPC,
        /// <summary>Represents the value 'PJP' in the XML</summary>
        [LxEnumValue("PJP")]
        PJP,
        /// <summary>Represents the value 'RPU' in the XML</summary>
        [LxEnumValue("RPU")]
        RPU,
        /// <summary>Represents the value 'THP' in the XML</summary>
        [LxEnumValue("THP")]
        THP,
        /// <summary>Represents the value 'UNC' in the XML</summary>
        [LxEnumValue("UNC")]
        UNC,
        /// <summary>Represents the value 'WEP' in the XML</summary>
        [LxEnumValue("WEP")]
        WEP,
        /// <summary>Represents the value 'XMP' in the XML</summary>
        [LxEnumValue("XMP")]
        XMP,
        /// <summary>Represents the value 'XPU' in the XML</summary>
        [LxEnumValue("XPU")]
        XPU,
    }
    /// <summary>An enumeration representing XSD simple type VolumeUnitType</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/simpleType:VolumeUnitType</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>299:2-305:18</XsdLocation>
    [LxSimpleTypeDefinition("VolumeUnitType", "")]
    public enum VolumeUnitTypeEnum
    {
        /// <summary>Represents the value 'CI' in the XML</summary>
        [LxEnumValue("CI")]
        CI,
        /// <summary>Represents the value 'CC' in the XML</summary>
        [LxEnumValue("CC")]
        CC,
        /// <summary>Represents the value 'CF' in the XML</summary>
        [LxEnumValue("CF")]
        CF,
    }
    /// <summary>An enumeration representing XSD simple type WeightUnitType</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/simpleType:WeightUnitType</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>287:2-292:18</XsdLocation>
    [LxSimpleTypeDefinition("WeightUnitType", "")]
    public enum WeightUnitTypeEnum
    {
        /// <summary>Represents the value 'L' in the XML</summary>
        [LxEnumValue("L")]
        L,
        /// <summary>Represents the value 'K' in the XML</summary>
        [LxEnumValue("K")]
        K,
    }
    /// <summary>An enumeration representing XSD simple type YNType</summary>
    /// <remarks>base type for 1 char Y/N</remarks>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/simpleType:YNType</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>311:2-321:18</XsdLocation>
    [LxSimpleTypeDefinition("YNType", "")]
    public enum YNTypeEnum
    {
        /// <summary>Represents the value 'Y' in the XML</summary>
        [LxEnumValue("Y")]
        Y,
        /// <summary>Represents the value 'N' in the XML</summary>
        [LxEnumValue("N")]
        N,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType DeliveryAccessorials</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:DeliveryAccessorials</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>154:2-160:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DeliveryAccessorials", "")]
    public partial class DeliveryAccessorialsCt
    {
        /// <summary>A collection of <see cref="ForwardAirRestApp.Ns.DeliveryAccessorialTypeEnum" /></summary>
        [LxElementValue(0, "DeliveryAccessorial", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, WhiteSpace = WhiteSpaceType.Preserve)]
        public List<ForwardAirRestApp.Ns.DeliveryAccessorialTypeEnum> DeliveryAccessorials { get; } = new List<ForwardAirRestApp.Ns.DeliveryAccessorialTypeEnum>();

    }

    /// <summary>A class representing the root XSD complexType Delivery</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:Delivery</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>129:2-136:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("Delivery", "")]
    public partial class DeliveryCt
    {
        /// <summary>A <see cref="ForwardAirRestApp.Ns.YNTypeEnum" />, Required</summary>
        [LxElementValue(0, "AirportDelivery", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.YNTypeEnum AirportDelivery { get; set; }

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.DeliveryAccessorialsCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.DeliveryAccessorialsCt" />
        /// </summary>
        [LxElementCt(1, "DeliveryAccessorials", "", MinOccurs = 1, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.DeliveryAccessorialsCt DeliveryAccessorials { get; set; } = new ForwardAirRestApp.Ns.DeliveryAccessorialsCt();

    }

    /// <summary>A class representing the root XSD complexType Destination</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:Destination</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>107:2-120:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("Destination", "")]
    public partial class DestinationCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue(0, "DestinationAirportCode", "", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "3")]
        public System.String DestinationAirportCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue(1, "DestinationZipCode", "", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "10")]
        public System.String DestinationZipCode { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.DeliveryCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.DeliveryCt" />
        /// </summary>
        [LxElementCt(2, "Delivery", "", MinOccurs = 0, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.DeliveryCt Delivery { get; set; }

    }

    /// <summary>A class representing the root XSD complexType Dimension</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:Dimension</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>59:2-70:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("Dimension", "")]
    public partial class DimensionCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(0, "Pieces", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Pieces { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(1, "Length", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Length { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(2, "Width", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Width { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(3, "Height", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Height { get; set; }

    }

    /// <summary>A class representing the root XSD complexType Dimensions</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:Dimensions</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>50:2-57:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("Dimensions", "")]
    public partial class DimensionsCt
    {
        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.DimensionCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.DimensionCt" />
        /// </summary>
        [LxElementCt(0, "Dimension", "", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<ForwardAirRestApp.Ns.DimensionCt> Dimensions { get; } = new List<ForwardAirRestApp.Ns.DimensionCt>();

    }

    /// <summary>A class representing the root XSD complexType FAQuoteRequest</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:FAQuoteRequest</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>8:2-49:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("FAQuoteRequest", "")]
    public partial class FAQuoteRequestCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(0, "BillToCustomerNumber", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "7")]
        public System.Numerics.BigInteger BillToCustomerNumber { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(1, "ShipperCustomerNumber", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "7")]
        public System.Numerics.BigInteger ShipperCustomerNumber { get; set; }

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.OriginCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.OriginCt" />
        /// </summary>
        [LxElementCt(2, "Origin", "", MinOccurs = 1, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.OriginCt Origin { get; set; } = new ForwardAirRestApp.Ns.OriginCt();

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.DestinationCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.DestinationCt" />
        /// </summary>
        [LxElementCt(3, "Destination", "", MinOccurs = 1, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.DestinationCt Destination { get; set; } = new ForwardAirRestApp.Ns.DestinationCt();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        [LxElementValue(4, "Volume", "", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.BigDecimal? Volume { get; set; }

        /// <summary>A nullable <see cref="ForwardAirRestApp.Ns.VolumeUnitTypeEnum" />, Optional : null when not set</summary>
        [LxElementValue(5, "VolumeType", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.VolumeUnitTypeEnum? VolumeType { get; set; }

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.DimensionsCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.DimensionsCt" />
        /// </summary>
        [LxElementCt(6, "Dimensions", "", MinOccurs = 0, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.DimensionsCt Dimensions { get; set; }

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.FreightDetailsCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.FreightDetailsCt" />
        /// </summary>
        [LxElementCt(7, "FreightDetails", "", MinOccurs = 1, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.FreightDetailsCt FreightDetails { get; set; } = new ForwardAirRestApp.Ns.FreightDetailsCt();

        /// <summary>A <see cref="ForwardAirRestApp.Ns.YNTypeEnum" />, Required</summary>
        [LxElementValue(8, "Hazmat", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.YNTypeEnum Hazmat { get; set; }

        /// <summary>A <see cref="ForwardAirRestApp.Ns.YNTypeEnum" />, Required</summary>
        [LxElementValue(9, "InBondShipment", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.YNTypeEnum InBondShipment { get; set; }

        /// <summary>A nullable <see cref="ForwardAirRestApp.Ns.YNTypeEnum" />, Optional : null when not set</summary>
        [LxElementValue(10, "GuaranteedService", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.YNTypeEnum? GuaranteedService { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        [LxElementValue(11, "DeclaredValue", "", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.BigDecimal DeclaredValue { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        [LxElementValue(12, "ShippingDate", "", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime ShippingDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType FreightDetail</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:FreightDetail</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>79:2-92:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("FreightDetail", "")]
    public partial class FreightDetailCt
    {
        /// <summary>A <see cref="ForwardAirRestApp.Ns.FreightClassTypeEnum" />, Required</summary>
        [LxElementValue(0, "FreightClass", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.FreightClassTypeEnum FreightClass { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue(1, "Description", "", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Description { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue(2, "Pieces", "", LxValueType.Value, XsdType.XsdPositiveInteger, MinOccurs = 1, MaxOccurs = 1, MaxInclusive = "999")]
        public System.Numerics.BigInteger Pieces { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        [LxElementValue(3, "Weight", "", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.BigDecimal Weight { get; set; }

        /// <summary>A <see cref="ForwardAirRestApp.Ns.WeightUnitTypeEnum" />, Required</summary>
        [LxElementValue(4, "WeightType", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.WeightUnitTypeEnum WeightType { get; set; }

    }

    /// <summary>A class representing the root XSD complexType FreightDetails</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:FreightDetails</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>71:2-78:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("FreightDetails", "")]
    public partial class FreightDetailsCt
    {
        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.FreightDetailCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.FreightDetailCt" />
        /// </summary>
        [LxElementCt(0, "FreightDetail", "", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<ForwardAirRestApp.Ns.FreightDetailCt> FreightDetails { get; } = new List<ForwardAirRestApp.Ns.FreightDetailCt>();

    }

    /// <summary>A class representing the root XSD complexType Origin</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:Origin</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>93:2-106:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("Origin", "")]
    public partial class OriginCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue(0, "OriginAirportCode", "", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "3")]
        public System.String OriginAirportCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue(1, "OriginZipCode", "", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "10")]
        public System.String OriginZipCode { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.PickupCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.PickupCt" />
        /// </summary>
        [LxElementCt(2, "Pickup", "", MinOccurs = 0, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.PickupCt Pickup { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PickupAccessorials</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:PickupAccessorials</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>147:2-153:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PickupAccessorials", "")]
    public partial class PickupAccessorialsCt
    {
        /// <summary>A collection of <see cref="ForwardAirRestApp.Ns.PickupAccessorialTypeEnum" /></summary>
        [LxElementValue(0, "PickupAccessorial", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, WhiteSpace = WhiteSpaceType.Preserve)]
        public List<ForwardAirRestApp.Ns.PickupAccessorialTypeEnum> PickupAccessorials { get; } = new List<ForwardAirRestApp.Ns.PickupAccessorialTypeEnum>();

    }

    /// <summary>A class representing the root XSD complexType Pickup</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/complexType:Pickup</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>121:2-128:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("Pickup", "")]
    public partial class PickupCt
    {
        /// <summary>A <see cref="ForwardAirRestApp.Ns.YNTypeEnum" />, Required</summary>
        [LxElementValue(0, "AirportPickup", "", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public ForwardAirRestApp.Ns.YNTypeEnum AirportPickup { get; set; }

        /// <summary>
        ///   A class derived from <see cref="ForwardAirRestApp.Ns.PickupAccessorialsCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="ForwardAirRestApp.Ns.PickupAccessorialsCt" />
        /// </summary>
        [LxElementCt(1, "PickupAccessorials", "", MinOccurs = 1, MaxOccurs = 1)]
        public ForwardAirRestApp.Ns.PickupAccessorialsCt PickupAccessorials { get; set; } = new ForwardAirRestApp.Ns.PickupAccessorialsCt();

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element FAQuoteRequest</summary>
    /// <XsdPath>schema:ForwardAirQuoteRequest-...xsd/element:FAQuoteRequest</XsdPath>
    /// <XsdFile>C:\Repos\Tests\ForwardAirApp\ForwardAirRestApp\ForwardAirQuoteRequest-schema_v2.xsd</XsdFile>
    /// <XsdLocation>6:2-7:32</XsdLocation>
    [LxSimpleElementDefinition("FAQuoteRequest", "", ElementScopeType.GlobalElement)]
    public partial class FAQuoteRequestElm : ForwardAirRestApp.Ns.FAQuoteRequestCt
    {
    }

    #endregion

}

namespace ForwardAirRestApp.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace ForwardAirRestApp
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class ForwardAirQuoteRequestSchemaV2Validator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public ForwardAirQuoteRequestSchemaV2Validator()
            : base(typeof(ForwardAirQuoteRequestSchemaV2Validator).Assembly, "ForwardAirRestApp.ForwardAirQuoteRequestSchemaV2Resources.SchemaData")
        {
        }
    }
}