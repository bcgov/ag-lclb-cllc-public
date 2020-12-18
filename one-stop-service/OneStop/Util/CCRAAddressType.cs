﻿/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CCRAAddressType {
    
    private string addressLine1TextField;
    
    private string addressLine2TextField;
    
    private string cityNameField;
    
    private string countryCodeField;
    
    private string provinceStateCodeField;
    
    private string postalZipCodeField;
    
    private System.DateTime effectiveDateField;
    
    private bool effectiveDateFieldSpecified;
    
    private string sequenceNumberField;
    
    /// <remarks/>
    public string addressLine1Text {
        get {
            return this.addressLine1TextField;
        }
        set {
            this.addressLine1TextField = value;
        }
    }
    
    /// <remarks/>
    public string addressLine2Text {
        get {
            return this.addressLine2TextField;
        }
        set {
            this.addressLine2TextField = value;
        }
    }
    
    /// <remarks/>
    public string cityName {
        get {
            return this.cityNameField;
        }
        set {
            this.cityNameField = value;
        }
    }
    
    /// <remarks/>
    public string countryCode {
        get {
            return this.countryCodeField;
        }
        set {
            this.countryCodeField = value;
        }
    }
    
    /// <remarks/>
    public string provinceStateCode {
        get {
            return this.provinceStateCodeField;
        }
        set {
            this.provinceStateCodeField = value;
        }
    }
    
    /// <remarks/>
    public string postalZipCode {
        get {
            return this.postalZipCodeField;
        }
        set {
            this.postalZipCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime effectiveDate {
        get {
            return this.effectiveDateField;
        }
        set {
            this.effectiveDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool effectiveDateSpecified {
        get {
            return this.effectiveDateFieldSpecified;
        }
        set {
            this.effectiveDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string sequenceNumber {
        get {
            return this.sequenceNumberField;
        }
        set {
            this.sequenceNumberField = value;
        }
    }
}