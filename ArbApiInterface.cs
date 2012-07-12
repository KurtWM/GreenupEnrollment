﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetNuke.Modules.GreenupEnrollment
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("ErrorResponse", Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ANetApiResponse
    {

        /// <remarks/>
        public string refId;

        /// <remarks/>
        public messagesType messages;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class messagesType
    {

        /// <remarks/>
        public messageTypeEnum resultCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public messagesTypeMessage[] message;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum messageTypeEnum
    {

        /// <remarks/>
        Ok,

        /// <remarks/>
        Error,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class messagesTypeMessage
    {

        /// <remarks/>
        public string code;

        /// <remarks/>
        public string text;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransVoidType
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public string customerShippingAddressId;

        /// <remarks/>
        public string transId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class lineItemType
    {

        /// <remarks/>
        public string itemId;

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string description;

        /// <remarks/>
        public decimal quantity;

        /// <remarks/>
        public decimal unitPrice;

        /// <remarks/>
        public bool taxable;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxableSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class extendedAmountType
    {

        /// <remarks/>
        public decimal amount;

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string description;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransRefundType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransPriorAuthCaptureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransOrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransCaptureOnlyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransAuthOnlyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransAuthCaptureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransAmountType
    {

        /// <remarks/>
        public decimal amount;

        /// <remarks/>
        public extendedAmountType tax;

        /// <remarks/>
        public extendedAmountType shipping;

        /// <remarks/>
        public extendedAmountType duty;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineItems")]
        public lineItemType[] lineItems;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransRefundType : profileTransAmountType
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public string customerShippingAddressId;

        /// <remarks/>
        public string creditCardNumberMasked;

        /// <remarks/>
        public string bankRoutingNumberMasked;

        /// <remarks/>
        public string bankAccountNumberMasked;

        /// <remarks/>
        public orderExType order;

        /// <remarks/>
        public string transId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class orderExType : orderType
    {

        /// <remarks/>
        public string purchaseOrderNumber;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(orderExType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class orderType
    {

        /// <remarks/>
        public string invoiceNumber;

        /// <remarks/>
        public string description;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransPriorAuthCaptureType : profileTransAmountType
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public string customerShippingAddressId;

        /// <remarks/>
        public string transId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransCaptureOnlyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransAuthOnlyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profileTransAuthCaptureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransOrderType : profileTransAmountType
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public string customerShippingAddressId;

        /// <remarks/>
        public orderExType order;

        /// <remarks/>
        public bool taxExempt;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxExemptSpecified;

        /// <remarks/>
        public bool recurringBilling;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurringBillingSpecified;

        /// <remarks/>
        public string cardCode;

        /// <remarks/>
        public string splitTenderId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransCaptureOnlyType : profileTransOrderType
    {

        /// <remarks/>
        public string approvalCode;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransAuthOnlyType : profileTransOrderType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransAuthCaptureType : profileTransOrderType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class profileTransactionType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("profileTransAuthCapture", typeof(profileTransAuthCaptureType))]
        [System.Xml.Serialization.XmlElementAttribute("profileTransAuthOnly", typeof(profileTransAuthOnlyType))]
        [System.Xml.Serialization.XmlElementAttribute("profileTransCaptureOnly", typeof(profileTransCaptureOnlyType))]
        [System.Xml.Serialization.XmlElementAttribute("profileTransPriorAuthCapture", typeof(profileTransPriorAuthCaptureType))]
        [System.Xml.Serialization.XmlElementAttribute("profileTransRefund", typeof(profileTransRefundType))]
        [System.Xml.Serialization.XmlElementAttribute("profileTransVoid", typeof(profileTransVoidType))]
        public object Item;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class driversLicenseMaskedType
    {

        /// <remarks/>
        public string number;

        /// <remarks/>
        public string state;

        /// <remarks/>
        public string dateOfBirth;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class bankAccountMaskedType
    {

        /// <remarks/>
        public bankAccountTypeEnum accountType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountTypeSpecified;

        /// <remarks/>
        public string routingNumber;

        /// <remarks/>
        public string accountNumber;

        /// <remarks/>
        public string nameOnAccount;

        /// <remarks/>
        public echeckTypeEnum echeckType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool echeckTypeSpecified;

        /// <remarks/>
        public string bankName;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum bankAccountTypeEnum
    {

        /// <remarks/>
        checking,

        /// <remarks/>
        savings,

        /// <remarks/>
        businessChecking,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum echeckTypeEnum
    {

        /// <remarks/>
        PPD,

        /// <remarks/>
        WEB,

        /// <remarks/>
        CCD,

        /// <remarks/>
        TEL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class creditCardMaskedType
    {

        /// <remarks/>
        public string cardNumber;

        /// <remarks/>
        public string expirationDate;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class paymentMaskedType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bankAccount", typeof(bankAccountMaskedType))]
        [System.Xml.Serialization.XmlElementAttribute("creditCard", typeof(creditCardMaskedType))]
        public object Item;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerPaymentProfileMaskedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerPaymentProfileType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerPaymentProfileExType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerPaymentProfileBaseType
    {

        /// <remarks/>
        public customerTypeEnum customerType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool customerTypeSpecified;

        /// <remarks/>
        public customerAddressType billTo;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum customerTypeEnum
    {

        /// <remarks/>
        individual,

        /// <remarks/>
        business,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerAddressExType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerAddressType : nameAndAddressType
    {

        /// <remarks/>
        public string phoneNumber;

        /// <remarks/>
        public string faxNumber;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerAddressType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerAddressExType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class nameAndAddressType
    {

        /// <remarks/>
        public string firstName;

        /// <remarks/>
        public string lastName;

        /// <remarks/>
        public string company;

        /// <remarks/>
        public string address;

        /// <remarks/>
        public string city;

        /// <remarks/>
        public string state;

        /// <remarks/>
        public string zip;

        /// <remarks/>
        public string country;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerAddressExType : customerAddressType
    {

        /// <remarks/>
        public string customerAddressId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerPaymentProfileMaskedType : customerPaymentProfileBaseType
    {

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public paymentMaskedType payment;

        /// <remarks/>
        public driversLicenseMaskedType driversLicense;

        /// <remarks/>
        public string taxId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerPaymentProfileExType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerPaymentProfileType : customerPaymentProfileBaseType
    {

        /// <remarks/>
        public paymentType payment;

        /// <remarks/>
        public driversLicenseType driversLicense;

        /// <remarks/>
        public string taxId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class paymentType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bankAccount", typeof(bankAccountType))]
        [System.Xml.Serialization.XmlElementAttribute("creditCard", typeof(creditCardType))]
        public object Item;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class bankAccountType
    {

        /// <remarks/>
        public bankAccountTypeEnum accountType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountTypeSpecified;

        /// <remarks/>
        public string routingNumber;

        /// <remarks/>
        public string accountNumber;

        /// <remarks/>
        public string nameOnAccount;

        /// <remarks/>
        public echeckTypeEnum echeckType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool echeckTypeSpecified;

        /// <remarks/>
        public string bankName;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class creditCardType : creditCardSimpleType
    {

        /// <remarks/>
        public string cardCode;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(creditCardType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class creditCardSimpleType
    {

        /// <remarks/>
        public string cardNumber;

        /// <remarks/>
        public string expirationDate;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class driversLicenseType
    {

        /// <remarks/>
        public string number;

        /// <remarks/>
        public string state;

        /// <remarks/>
        public string dateOfBirth;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerPaymentProfileExType : customerPaymentProfileType
    {

        /// <remarks/>
        public string customerPaymentProfileId;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerProfileExType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerProfileMaskedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerProfileType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerProfileBaseType
    {

        /// <remarks/>
        public string merchantCustomerId;

        /// <remarks/>
        public string description;

        /// <remarks/>
        public string email;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(customerProfileMaskedType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerProfileExType : customerProfileBaseType
    {

        /// <remarks/>
        public string customerProfileId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerProfileMaskedType : customerProfileExType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentProfiles")]
        public customerPaymentProfileMaskedType[] paymentProfiles;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipToList")]
        public customerAddressExType[] shipToList;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerProfileType : customerProfileBaseType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentProfiles")]
        public customerPaymentProfileType[] paymentProfiles;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipToList")]
        public customerAddressType[] shipToList;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class customerType
    {

        /// <remarks/>
        public customerTypeEnum type;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified;

        /// <remarks/>
        public string id;

        /// <remarks/>
        public string email;

        /// <remarks/>
        public string phoneNumber;

        /// <remarks/>
        public string faxNumber;

        /// <remarks/>
        public driversLicenseType driversLicense;

        /// <remarks/>
        public string taxId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class paymentScheduleType
    {

        /// <remarks/>
        public paymentScheduleTypeInterval interval;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime startDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified;

        /// <remarks/>
        public short totalOccurrences;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalOccurrencesSpecified;

        /// <remarks/>
        public short trialOccurrences;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trialOccurrencesSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class paymentScheduleTypeInterval
    {

        /// <remarks/>
        public short length;

        /// <remarks/>
        public ARBSubscriptionUnitEnum unit;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum ARBSubscriptionUnitEnum
    {

        /// <remarks/>
        days,

        /// <remarks/>
        months,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class ARBSubscriptionType
    {

        /// <remarks/>
        public string name;

        /// <remarks/>
        public paymentScheduleType paymentSchedule;

        /// <remarks/>
        public decimal amount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified;

        /// <remarks/>
        public decimal trialAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trialAmountSpecified;

        /// <remarks/>
        public paymentType payment;

        /// <remarks/>
        public orderType order;

        /// <remarks/>
        public customerType customer;

        /// <remarks/>
        public nameAndAddressType billTo;

        /// <remarks/>
        public nameAndAddressType shipTo;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class merchantAuthenticationType
    {

        /// <remarks/>
        public string name;

        /// <remarks/>
        public string transactionKey;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public partial class ANetApiRequest
    {

        /// <remarks/>
        public merchantAuthenticationType merchantAuthentication;

        /// <remarks/>
        public string refId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class isAliveRequest
    {

        /// <remarks/>
        public string refId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class isAliveResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class authenticateTestRequest : ANetApiRequest
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class authenticateTestResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBCreateSubscriptionRequest : ANetApiRequest
    {

        /// <remarks/>
        public ARBSubscriptionType subscription;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBCreateSubscriptionResponse : ANetApiResponse
    {

        /// <remarks/>
        public string subscriptionId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBUpdateSubscriptionRequest : ANetApiRequest
    {

        /// <remarks/>
        public string subscriptionId;

        /// <remarks/>
        public ARBSubscriptionType subscription;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBUpdateSubscriptionResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBCancelSubscriptionRequest : ANetApiRequest
    {

        /// <remarks/>
        public string subscriptionId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBCancelSubscriptionResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBGetSubscriptionStatusRequest : ANetApiRequest
    {

        /// <remarks/>
        public string subscriptionId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class ARBGetSubscriptionStatusResponse : ANetApiResponse
    {

        /// <remarks/>
        public ARBSubscriptionStatusEnum Status;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum ARBSubscriptionStatusEnum
    {

        /// <remarks/>
        active,

        /// <remarks/>
        expired,

        /// <remarks/>
        suspended,

        /// <remarks/>
        canceled,

        /// <remarks/>
        terminated,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public customerProfileType profile;

        /// <remarks/>
        public validationModeEnum validationMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validationModeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum validationModeEnum
    {

        /// <remarks/>
        none,

        /// <remarks/>
        testMode,

        /// <remarks/>
        liveMode,

        /// <remarks/>
        oldLiveMode,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerProfileResponse : ANetApiResponse
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("numericString", IsNullable = false)]
        public string[] customerPaymentProfileIdList;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("numericString", IsNullable = false)]
        public string[] customerShippingAddressIdList;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public string[] validationDirectResponseList;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerPaymentProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public customerPaymentProfileType paymentProfile;

        /// <remarks/>
        public validationModeEnum validationMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validationModeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerPaymentProfileResponse : ANetApiResponse
    {

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public string validationDirectResponse;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerShippingAddressRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public customerAddressType address;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerShippingAddressResponse : ANetApiResponse
    {

        /// <remarks/>
        public string customerAddressId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerProfileResponse : ANetApiResponse
    {

        /// <remarks/>
        public customerProfileMaskedType profile;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerPaymentProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerPaymentProfileResponse : ANetApiResponse
    {

        /// <remarks/>
        public customerPaymentProfileMaskedType paymentProfile;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerShippingAddressRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerAddressId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerShippingAddressResponse : ANetApiResponse
    {

        /// <remarks/>
        public customerAddressExType address;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateCustomerProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public customerProfileExType profile;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateCustomerProfileResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateCustomerPaymentProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public customerPaymentProfileExType paymentProfile;

        /// <remarks/>
        public validationModeEnum validationMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validationModeSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateCustomerPaymentProfileResponse : ANetApiResponse
    {

        /// <remarks/>
        public string validationDirectResponse;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateCustomerShippingAddressRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public customerAddressExType address;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateCustomerShippingAddressResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class deleteCustomerProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class deleteCustomerProfileResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class deleteCustomerPaymentProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class deleteCustomerPaymentProfileResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class deleteCustomerShippingAddressRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerAddressId;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class deleteCustomerShippingAddressResponse : ANetApiResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerProfileTransactionRequest : ANetApiRequest
    {

        /// <remarks/>
        public profileTransactionType transaction;

        /// <remarks/>
        public string extraOptions;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class createCustomerProfileTransactionResponse : ANetApiResponse
    {

        /// <remarks/>
        public string directResponse;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class validateCustomerPaymentProfileRequest : ANetApiRequest
    {

        /// <remarks/>
        public string customerProfileId;

        /// <remarks/>
        public string customerPaymentProfileId;

        /// <remarks/>
        public string customerShippingAddressId;

        /// <remarks/>
        public string cardCode;

        /// <remarks/>
        public validationModeEnum validationMode;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class validateCustomerPaymentProfileResponse : ANetApiResponse
    {

        /// <remarks/>
        public string directResponse;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerProfileIdsRequest : ANetApiRequest
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class getCustomerProfileIdsResponse : ANetApiResponse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("numericString", IsNullable = false)]
        public string[] ids;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateSplitTenderGroupRequest : ANetApiRequest
    {

        /// <remarks/>
        public string splitTenderId;

        /// <remarks/>
        public splitTenderStatusEnum splitTenderStatus;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    public enum splitTenderStatusEnum
    {

        /// <remarks/>
        completed,

        /// <remarks/>
        held,

        /// <remarks/>
        voided,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "AnetApi/xml/v1/schema/AnetApiSchema.xsd", IsNullable = false)]
    public partial class updateSplitTenderGroupResponse : ANetApiResponse
    {
    }
}