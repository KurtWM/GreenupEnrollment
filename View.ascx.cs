using System;
using System.IO;
using System.Data;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.CSharp;
using DotNetNuke.Common;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Security;
using DotNetNuke.Entities.Portals;
using DotNetNuke.UI.Skins;
using DotNetNuke.Common.Utilities;



namespace DotNetNuke.Modules.GreenupEnrollment
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The View class displays the content
    /// 
    /// Typically your view control would be used to display content or functionality in your module.
    /// 
    /// View may be the only control you have in your project depending on the complexity of your module
    /// 
    /// Because the control inherits from GreenupEnrollmentModuleBase you have access to any custom properties
    /// defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
    /// 
    /// </summary>
    /// -----------------------------------------------------------------------------
    public partial class View : PortalModuleBase, IActionable
    {
        System.Configuration.Configuration rootWebConfig1 = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);

        #region Authorize.net ARB variables

        // This is the URL of the API server.
        // You must give this a valid value to successfully execute this sample code.
        private static string _apiUrl = @"https://apitest.authorize.net/xml/v1/request.api";

        // This will be set by CreateSubscription and used for the UpdateSubscription 
        // and CancelSubscription
        private static string _subscriptionId = "";

        // controls whether the XML request and response are written to the console
        private static bool _dumpXml;
        StringBuilder sb_dumpXml;

        #endregion

        #region Event Handlers

        //override protected void OnInit(EventArgs e)
        //{
        //    InitializeComponent();
        //    base.OnInit(e);
        //}

        //private void InitializeComponent()
        //{
        //    this.Load += new System.EventHandler(this.Page_Load);
        //}

        private void Page_Init(object sender, System.EventArgs e)
        {
          HomeImageButton_S.ImageUrl = this.TemplateSourceDirectory + "/Images/house-small.png";
          HomeImageButton_M.ImageUrl = this.TemplateSourceDirectory + "/Images/house-medium.png";
          HomeImageButton_L.ImageUrl = this.TemplateSourceDirectory + "/Images/house-big.png";
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Page_Load runs when the control is loaded
        /// </summary>
        /// -----------------------------------------------------------------------------
        private void Page_Load(object sender, System.EventArgs e)
        {

          string v = Request.QueryString["param"];
          if (v != null)
          {
            Response.Write("param is ");
            Response.Write(v);
          }


          if ((string)Settings["KwhPrice"] != "")
          {
            KwhPrice.Value = (string)Settings["KwhPrice"];
          }
            Page.ClientScript.RegisterClientScriptInclude(this.GetType(), "GreenupEnrollment", (this.TemplateSourceDirectory + "/JScript.js"));
            //GreenupEnrollmentWizard.ActiveStepChanged += Wizard_ActiveStepChanged;
            //GreenupEnrollmentWizard.FinishButtonClick += Wizard_FinishButtonClick;
            //GreenupEnrollmentWizard.NextButtonClick += Wizard_NextButtonClick;
            try
            {
              GreenupEnrollmentWizard.StartNextButtonText = Localization.GetString("Next", LocalResourceFile);
              GreenupEnrollmentWizard.StepNextButtonText = Localization.GetString("Next", LocalResourceFile);
              GreenupEnrollmentWizard.StepPreviousButtonText = Localization.GetString("Previous", LocalResourceFile);
              GreenupEnrollmentWizard.FinishPreviousButtonText = Localization.GetString("Previous", LocalResourceFile);
              GreenupEnrollmentWizard.FinishCompleteButtonText = Localization.GetString("Finish", LocalResourceFile);
              //GreenupEnrollmentWizard.StartNextButtonText = "<img src=\"" + Globals.ApplicationPath + "/images/rt.gif\" border=\"0\" /> " + Localization.GetString("Next", LocalResourceFile);
                //GreenupEnrollmentWizard.StepNextButtonText = "<img src=\"" + Globals.ApplicationPath + "/images/rt.gif\" border=\"0\" /> " + Localization.GetString("Next", LocalResourceFile);
                //GreenupEnrollmentWizard.StepPreviousButtonText = "<img src=\"" + Globals.ApplicationPath + "/images/lt.gif\" border=\"0\" /> " + Localization.GetString("Previous", LocalResourceFile);
                //GreenupEnrollmentWizard.FinishPreviousButtonText = "<img src=\"" + Globals.ApplicationPath + "/images/lt.gif\" border=\"0\" /> " + Localization.GetString("Previous", LocalResourceFile);
                //GreenupEnrollmentWizard.FinishCompleteButtonText = "<img src=\"" + Globals.ApplicationPath + "/images/save.gif\" border=\"0\" /> " + Localization.GetString("Finish", LocalResourceFile);
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }

            // BEGIN Authorize.net ARB test
            bool bResult = false;

            if (bResult)
            {
              lblMessage.Text += ("API server: " + _apiUrl);

              // Set this to true if you want to see the XML requests and responses dumped
              // to the console window. Set to false otherwise.
              _dumpXml = true;

              // Create a new subscription
              lblMessage.Text += ("<br /><br /><strong>This call to ARBCreateSubscription should be successful.</strong>");
              bResult = CreateSubscription(false);

              // This example will generate an error because a duplicate subscription
              // is being created.
              lblMessage.Text += ("<br /><br /><strong>This call to ARBCreateSubscription shows how to handle errors.</strong>");
              CreateSubscription(false);

              // This example will generate an error because the Amount is missing causing
              // a schema validatation error to occur on the server side.
              lblMessage.Text += ("<br /><br /><strong>This call to ARBCreateSubscription shows how to process ErrorResponse.</strong>");
              CreateSubscription(true);

              // Update the subscription that was just created
              if (bResult && _subscriptionId != null)
              {
                lblMessage.Text += ("<br /><br /><strong>This call to ARBUpdateSubscription should be successful.</strong>");
                bResult = UpdateSubscription();

                // Cancel the subscription that was just created
                if (bResult)
                {
                  lblMessage.Text += ("<br /><br /><strong>This call to ARBCancelSubscription should be successful.</strong>");
                  bResult = CancelSubscription();
                }

                // Get the status of the subscription we just canceled
                bResult = GetStatusSubscription();
              }
            }
            // END Authorize.net ARB test

            //Button btnNext = GetControlFromWizard(GreenupEnrollmentWizard, WizardNavigationTempContainer.StartNavigationTemplateContainerID, "btnNext") as Button;
            //btnNext.Enabled = false;


        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// OnFinishButtonClick runs when the onfinishbuttonclick property is called from
        /// the GreenupEnrollmentWizard Wizard control.
        /// </summary>
        /// -----------------------------------------------------------------------------
        protected void OnFinishButtonClick(Object sender, WizardNavigationEventArgs e)
        {
            // The OnFinishButtonClick method is a good place to collect all
            // the data from the completed pages and persist it to the data store. 
          bool bResult = true;
          bResult = CreateSubscription(false);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// The OnActiveStepChanged event is raised when the Wizard changes to a new step.
        /// </summary>
        /// -----------------------------------------------------------------------------
        protected void OnActiveStepChanged(object sender, EventArgs e)
        {
          // If the ActiveStep is changing to wizAlternateContact, check to see whether the 
          // AlternateContactCheckBox is selected.  If it is not, skip to the
          // Finish step.
          if (GreenupEnrollmentWizard.ActiveStepIndex == GreenupEnrollmentWizard.WizardSteps.IndexOf(this.wizAlternateContact))
          {
              if (this.AlternateContactCheckBox.Checked)
              {
                  GreenupEnrollmentWizard.MoveTo(this.wizAlternateContact);
              }
              else
              {
                  GreenupEnrollmentWizard.MoveTo(this.wizFinish);
              }
          }

          if (GreenupEnrollmentWizard.ActiveStepIndex == GreenupEnrollmentWizard.WizardSteps.IndexOf(this.wizCommercialProgram))
          {
            if (ProgramType.Value == "Residential")
            {
              GreenupEnrollmentWizard.MoveTo(this.wizBillingInfo);
            }
          }

          decimal number;
          if (GreenupEnrollmentWizard.ActiveStepIndex == GreenupEnrollmentWizard.WizardSteps.IndexOf(this.wizResidentialProgram))
          {
            if (Decimal.TryParse(MonthCost.Value, out number))
            {
              GreenupEnrollmentWizard.MoveTo(this.wizBillingInfo);
            }
          }

          //if (GreenupEnrollmentWizard.ActiveStepIndex == GreenupEnrollmentWizard.WizardSteps.IndexOf(this.wizBillingInfo))
          //{
          //  if (ctlCaptcha.IsValid)
          //  {
          //    GreenupEnrollmentWizard.MoveTo(this.wizAlternateContact);
          //  }
          //  else
          //  {
          //    GreenupEnrollmentWizard.MoveTo(this.wizBillingInfo);
          //  }
          //}
        }

        //protected void Wizard_ActiveStepChanged(object sender, EventArgs e)
        //{
            //switch (GreenupEnrollmentWizard.ActiveStepIndex)
            //{
            //    case 3:
            //        break;
            //}
        //}

        //protected void Wizard_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        //{
            //
        //}

        //protected void Wizard_NextButtonClick(object sender, WizardNavigationEventArgs e)
        //{
            //switch (e.CurrentStepIndex)
            //{
            //    case 1:
            //        break;
            //}
        //}

        #endregion

        #region Authorize.net ARB (recurring billing) functions

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Create a new ARB Subscription.
        /// </summary>
        // ----------------------------------------------------------------------------------------
        private bool CreateSubscription(bool forceXmlError)
        {
            bool bResult = true;

            lblMessage.Text += ("<br /><em>Create subscription</em><br />");

            // This is the API interface object
            ARBCreateSubscriptionRequest createSubscriptionRequest = new ARBCreateSubscriptionRequest();

            // Populate the subscription request with test data
            PopulateSubscription(createSubscriptionRequest);
            if (forceXmlError) createSubscriptionRequest.merchantAuthentication = null;

            // The response type will normally be ARBCreateSubscriptionResponse.
            // However, in the case of an error such as an XML parsing error, the response
            // type will be ErrorResponse.

            object response = null;
            XmlDocument xmldoc = null;
            bResult = PostRequest(createSubscriptionRequest, out xmldoc);

            if (bResult) bResult = ProcessXmlResponse(xmldoc, out response);

            if (bResult) ProcessResponse(response);

            if (!bResult)
            {
                lblMessage.Text += ("An unexpected error occurred processing this request.");
            }

            return bResult;

        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Update an existing ARB subscription using the subscription ID returned by the create.
        /// </summary>
        // ----------------------------------------------------------------------------------------
        private bool UpdateSubscription()
        {
            bool bResult = true;

            lblMessage.Text += ("<br />Update subscription");

            // This is the API interface object
            ARBUpdateSubscriptionRequest updateSubscriptionRequest = new ARBUpdateSubscriptionRequest();

            // Populate the subscription request with test data
            PopulateSubscription(updateSubscriptionRequest);

            // The response type will normally be ARBUpdateSubscriptionResponse.
            // However, in the case of an error such as an XML parsing error, the response
            // type will be ErrorResponse.

            object response = null;
            XmlDocument xmldoc = null;
            bResult = PostRequest(updateSubscriptionRequest, out xmldoc);

            if (bResult) bResult = ProcessXmlResponse(xmldoc, out response);

            if (bResult) ProcessResponse(response);

            if (!bResult)
            {
                lblMessage.Text += ("An unexpected error occurred processing this request.");
            }

            return bResult;

        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Cancel an existing ARB subscription using the subscription ID returned by the create.
        /// </summary>
        // ----------------------------------------------------------------------------------------
        private bool CancelSubscription()
        {
            bool bResult = true;

            lblMessage.Text += ("<br />Cancel subscription");

            // This is the API interface object
            ARBCancelSubscriptionRequest cancelSubscriptionRequest = new ARBCancelSubscriptionRequest();

            // Populate the subscription request with test data
            PopulateSubscription(cancelSubscriptionRequest);

            // The response type will normally be ARBCancelSubscriptionRequest.
            // However, in the case of an error such as an XML parsing error, the response
            // type will be ErrorResponse.

            object response = null;
            XmlDocument xmldoc = null;
            bResult = PostRequest(cancelSubscriptionRequest, out xmldoc);

            if (bResult) bResult = ProcessXmlResponse(xmldoc, out response);

            if (bResult) ProcessResponse(response);

            if (!bResult)
            {
                lblMessage.Text += ("An unexpected error occurred processing this request.");
            }

            return bResult;

        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Get the status of an existing ARB subscription 
        /// </summary>
        // ----------------------------------------------------------------------------------------
        private bool GetStatusSubscription()
        {
            bool bResult = true;

            lblMessage.Text += ("<br /><em>Get subscription status</em><br />");

            // This is the API interface object
            ARBGetSubscriptionStatusRequest statusSubscriptionRequest = new ARBGetSubscriptionStatusRequest();

            // Populate the subscription request with test data
            PopulateSubscription(statusSubscriptionRequest);

            // The response type will normally be ARBGetSubscriptionStatusRequest.
            // However, in the case of an error such as an XML parsing error, the response
            // type will be ErrorResponse.

            object response = null;
            XmlDocument xmldoc = null;
            bResult = PostRequest(statusSubscriptionRequest, out xmldoc);

            if (bResult) bResult = ProcessXmlResponse(xmldoc, out response);

            if (bResult) ProcessResponse(response);
            ARBGetSubscriptionStatusResponse theResponse = (ARBGetSubscriptionStatusResponse)response;
            lblMessage.Text += ("Status Text: " + theResponse.Status + "<br />");


            if (!bResult)
            {
                lblMessage.Text += ("An unexpected error occurred processing this request.");
            }

            return bResult;

        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Fill in the given request with test data to create a new subscription.
        /// </summary>
        /// <param name="sub"></param>
        // ----------------------------------------------------------------------------------------
        private void PopulateSubscription(ARBCreateSubscriptionRequest request)
        {
            ARBSubscriptionType sub = new ARBSubscriptionType();
            creditCardType creditCard = new creditCardType();

            sub.name = "Greenup Subscription";

            creditCard.cardNumber = "4111111111111111";
            creditCard.expirationDate = "2029-07";  // required format for API is YYYY-MM
            sub.payment = new paymentType();
            sub.payment.Item = creditCard;

            sub.billTo = new nameAndAddressType();
            sub.billTo.firstName = BillingFirstName.Text;
            sub.billTo.lastName = BillingLastName.Text;
            sub.billTo.address = BillingAddressLine1.Text + (BillingAddressLine2.Text.Length > 0 ? ", " + BillingAddressLine2.Text : "");
            sub.billTo.city = BillingCity.Text;
            sub.billTo.state = BillingState.Text;
            sub.billTo.zip = BillingZipCode.Text;

            sub.shipTo = new nameAndAddressType();
            sub.shipTo.firstName = AlternateFirstName.Text;
            sub.shipTo.lastName = AlternateLastName.Text;
            sub.shipTo.address = AlternateAddress1.Text + (AlternateAddress2.Text.Length > 0 ? ", " + AlternateAddress2.Text : "");
            sub.shipTo.city = AlternateCity.Text;
            sub.shipTo.state = AlternateState.Text;
            sub.shipTo.zip = AlternateZipCode.Text;

            // Create a subscription that is monthly payments starting on the current date

            sub.paymentSchedule = new paymentScheduleType();
            sub.paymentSchedule.startDate =  DateTime.Now; //new DateTime(2019, 01, 1);
            sub.paymentSchedule.startDateSpecified = true;

            sub.paymentSchedule.totalOccurrences = 9999; //9999 means there is no end.
            sub.paymentSchedule.totalOccurrencesSpecified = true;

            // free 1 month trial
            //sub.paymentSchedule.trialOccurrences = 1;
            //sub.paymentSchedule.trialOccurrencesSpecified = true;
            //sub.trialAmount = 0.00M;
            //sub.trialAmountSpecified = true;

            sub.amount = System.Convert.ToDecimal(MonthCost.Value); // + "M");
            sub.amountSpecified = true;

            sub.paymentSchedule.interval = new paymentScheduleTypeInterval();
            sub.paymentSchedule.interval.length = 1;
            sub.paymentSchedule.interval.unit = ARBSubscriptionUnitEnum.months;

            sub.order = new orderType();
            sub.order.invoiceNumber = "";
            sub.order.description = "Purchase of " + AnnualkWh.Value + "kWh per month.";

            sub.customer = new customerType();
            sub.customer.email = EmailAddress.Text ;


            // Include authentication information
            PopulateMerchantAuthentication((ANetApiRequest)request);

            request.subscription = sub;
        }


        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Fill in the given request with test data used to update the subscription.
        /// </summary>
        /// <param name="sub"></param>
        // ----------------------------------------------------------------------------------------
        private static void PopulateSubscription(ARBUpdateSubscriptionRequest request)
        {
            ARBSubscriptionType sub = new ARBSubscriptionType();
            creditCardType creditCard = new creditCardType();

            request.subscriptionId = _subscriptionId;

            // For this sample I just want to update the credit card information.
            creditCard.cardNumber = "4111111111111111";
            creditCard.expirationDate = "2029-07";  // required format for API is YYYY-MM
            sub.payment = new paymentType();
            sub.payment.Item = creditCard;

            // Include authentication information
            PopulateMerchantAuthentication((ANetApiRequest)request);

            request.subscription = sub;
        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Fill in the given request with test data used to cancel the subscription.
        /// </summary>
        /// <param name="sub"></param>
        // ----------------------------------------------------------------------------------------
        private static void PopulateSubscription(ARBCancelSubscriptionRequest request)
        {
            ARBSubscriptionType sub = new ARBSubscriptionType();
            creditCardType creditCard = new creditCardType();

            request.subscriptionId = _subscriptionId;

            // Include authentication information
            PopulateMerchantAuthentication((ANetApiRequest)request);
        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Fill in the given request with test data used to retrieve the status of the subscription.
        /// </summary>
        /// <param name="sub"></param>
        // ----------------------------------------------------------------------------------------
        private static void PopulateSubscription(ARBGetSubscriptionStatusRequest request)
        {
            ARBSubscriptionType sub = new ARBSubscriptionType();
            creditCardType creditCard = new creditCardType();

            request.subscriptionId = _subscriptionId;

            // Include authentication information
            PopulateMerchantAuthentication((ANetApiRequest)request);
        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Fill in the merchant authentication. This data is required for all API methods.
        /// </summary>
        /// <param name="request"></param>
        // ----------------------------------------------------------------------------------------
        private static void PopulateMerchantAuthentication(ANetApiRequest request)
        {
            request.merchantAuthentication = new merchantAuthenticationType();
            request.merchantAuthentication.name = Config.GetSetting("AuthorizeNetLogin"); // _userLoginName;
            request.merchantAuthentication.transactionKey = Config.GetSetting("AuthorizeNetTransactionKey"); // _transactionKey;
            request.refId = "Sample";
        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Send the request to the API server and load the response into an XML document.
        /// An XmlSerializer is used to form the XML used in the request to the API server. 
        /// The response from the server is also XML. An XmlReader is used to process the
        /// response stream from the API server so that it can be loaded into an XmlDocument.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// True if successful, false if not. If true then the specified xmldoc will contain the
        /// response received from the API server.
        /// </returns>
        // ----------------------------------------------------------------------------------------
        private bool PostRequest(object apiRequest, out XmlDocument xmldoc)
        {
            bool bResult = false;
            XmlSerializer serializer;

            xmldoc = null;

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_apiUrl);
                webRequest.Method = "POST";
                webRequest.ContentType = "text/xml";
                webRequest.KeepAlive = true;

                // Serialize the request
                serializer = new XmlSerializer(apiRequest.GetType());
                XmlWriter writer = new XmlTextWriter(webRequest.GetRequestStream(), Encoding.UTF8);
                serializer.Serialize(writer, apiRequest);
                writer.Close();

                if (_dumpXml)
                {
                  //lblMessage.Text += ("<br /><br />");
                  //StreamWriter consoleOutput = new StreamWriter(Console.OpenStandardOutput());
                  //consoleOutput.AutoFlush = true;
                  //serializer.Serialize(consoleOutput, apiRequest);
                  //consoleOutput.Close();
                  //lblMessage.Text += ("<br /><br />");
                }

                // Get the response
                WebResponse webResponse = webRequest.GetResponse();

                // Load the response from the API server into an XmlDocument.
                xmldoc = new XmlDocument();
                xmldoc.Load(XmlReader.Create(webResponse.GetResponseStream()));

                if (_dumpXml)
                {
                //    XmlWriterSettings settings = new XmlWriterSettings();
                //    settings.Indent = true;
                //    settings.Encoding = Encoding.ASCII;
                //    XmlWriter consoleWriter = XmlWriter.Create(v.sb_dumpXml, settings);
                //    xmldoc.WriteTo(consoleWriter);
                //    consoleWriter.Close();
                //    v.lblMessage.Text += ("<br /><br />");
                }

                bResult = true;
            }
            catch (Exception ex)
            {
                lblMessage.Text += (ex.GetType().ToString() + ": " + ex.Message);
                bResult = false;
            }

            return bResult;
        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Deserialize the given XML document into the correct object type using the root
        /// node to determine the type of output object.
        /// 
        /// For any given API request the response can be one of two types:
        ///    ErorrResponse or [methodname]Response. 
        /// For example, the ARBCreateSubscriptionRequest would normally result in a response of
        /// ARBCreateSubscriptionResponse. This is also the name of the root node of the response.
        /// This name can be used to deserialize the response into local objects. 
        /// </summary>
        /// <param name="xmldoc">
        /// This is the XML document to process. It holds the response from the API server.
        /// </param>
        /// <param name="apiResponse">
        /// This will hold the deserialized object of the appropriate type.
        /// </param>
        /// <returns>
        /// True if successful, false if not.
        /// </returns>
        // ----------------------------------------------------------------------------------------
        private bool ProcessXmlResponse(XmlDocument xmldoc, out object apiResponse)
        {
            bool bResult = true;
            XmlSerializer serializer;

            apiResponse = null;

            try
            {
                // Use the root node to determine the type of response object to create
                switch (xmldoc.DocumentElement.Name)
                {
                    case "ARBCreateSubscriptionResponse":
                        serializer = new XmlSerializer(typeof(ARBCreateSubscriptionResponse));
                        apiResponse = (ARBCreateSubscriptionResponse)serializer.Deserialize(new StringReader(xmldoc.DocumentElement.OuterXml));
                        break;

                    case "ARBUpdateSubscriptionResponse":
                        serializer = new XmlSerializer(typeof(ARBUpdateSubscriptionResponse));
                        apiResponse = (ARBUpdateSubscriptionResponse)serializer.Deserialize(new StringReader(xmldoc.DocumentElement.OuterXml));
                        break;

                    case "ARBCancelSubscriptionResponse":
                        serializer = new XmlSerializer(typeof(ARBCancelSubscriptionResponse));
                        apiResponse = (ARBCancelSubscriptionResponse)serializer.Deserialize(new StringReader(xmldoc.DocumentElement.OuterXml));
                        break;

                    case "ARBGetSubscriptionStatusResponse":
                        serializer = new XmlSerializer(typeof(ARBGetSubscriptionStatusResponse));
                        apiResponse = (ARBGetSubscriptionStatusResponse)serializer.Deserialize(new StringReader(xmldoc.DocumentElement.OuterXml));
                        break;

                    case "ErrorResponse":
                        serializer = new XmlSerializer(typeof(ANetApiResponse));
                        apiResponse = (ANetApiResponse)serializer.Deserialize(new StringReader(xmldoc.DocumentElement.OuterXml));
                        break;

                    default:
                        lblMessage.Text += ("Unexpected type of object: " + xmldoc.DocumentElement.Name);
                        bResult = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                bResult = false;
                apiResponse = null;
                lblMessage.Text += (ex.GetType().ToString() + ": " + ex.Message);
            }

            return bResult;
        }

        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Determine the type of the response object and process accordingly.
        /// Since this is just sample code the only processing being done here is to write a few
        /// bits of information to the console window.
        /// </summary>
        /// <param name="response"></param>
        // ----------------------------------------------------------------------------------------
        private void ProcessResponse(object response)
        {
            // Every response is based on ANetApiResponse so you can always do this sort of type casting.
            ANetApiResponse baseResponse = (ANetApiResponse)response;

            // For this example, write a confirmation message to the Complete page
            // of the Wizard control.
            Label tempLabel = (Label)GreenupEnrollmentWizard.FindControl("CompleteMessageLabel");
            if (tempLabel != null)
            {
              tempLabel.Text = "Your order has been placed. An e-mail confirmation will be sent to "
              + (EmailAddress.Text.Length == 0 ? "your e-mail address" : EmailAddress.Text) + ".";
            }

            // Write the results to the Complete WizardStep
            lblMessage.Text += ("Result: ");
            lblMessage.Text += (baseResponse.messages.resultCode.ToString());

            // If the result code is "Ok" then the request was successfully processed.
            if (baseResponse.messages.resultCode == messageTypeEnum.Ok)
            {
                // CreateSubscription is the only method that returns additional data
                if (response.GetType() == typeof(ARBCreateSubscriptionResponse))
                {
                    ARBCreateSubscriptionResponse createResponse = (ARBCreateSubscriptionResponse)response;
                    _subscriptionId = createResponse.subscriptionId;

                    lblMessage.Text += ("<br />Subscription ID: " + _subscriptionId);

                    lblMessage.Text += ("<br />To view the detail page at the Authorize.net test site <a href=\"https:" + "//sandbox.authorize.net/UI/themes/sandbox/ARB/SubscriptionDetail.aspx?SubscrID=" + _subscriptionId + "\" target=\"_blank\">here</a>");
                }
            }
            else
            {
                // Write error messages to console window
                for (int i = 0; i < baseResponse.messages.message.Length; i++)
                {
                    lblMessage.Text += ("[" + baseResponse.messages.message[i].code
                            + "] " + baseResponse.messages.message[i].text);
                }
            }
        }

        #endregion

        #region Optional Interfaces

        public ModuleActionCollection ModuleActions
        {
            get
            {
                ModuleActionCollection Actions = new ModuleActionCollection();
                Actions.Add(GetNextActionID(), Localization.GetString("EditModule", this.LocalResourceFile), "", "", "", EditUrl(), false, SecurityAccessLevel.Edit, true, false);
                return Actions;
            }
        }

        #endregion

        protected void btnResidential_Click(object sender, ImageClickEventArgs e)
        {
          GreenupEnrollmentWizard.ActiveStepIndex = 3;
          ProgramType.Value = "Residential";
        }

        protected void btnCommercial_Click(object sender, ImageClickEventArgs e)
        {
          GreenupEnrollmentWizard.ActiveStepIndex = 4;
          ProgramType.Value = "Commercial";
        }

        protected void ddlPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
          ProgramLocation.Value = ddlPrograms.SelectedItem.Value;
        }

        protected void rblResidentialSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public enum WizardNavigationTempContainer
        {
          StartNavigationTemplateContainerID = 1,
          StepNavigationTemplateContainerID = 2,
          FinishNavigationTemplateContainerID = 3
        }

        private Control GetControlFromWizard(Wizard wizard, WizardNavigationTempContainer wzdTemplate, string controlName)
        {
          System.Text.StringBuilder strCtrl = new System.Text.StringBuilder();
          strCtrl.Append(wzdTemplate);
          strCtrl.Append("$");
          strCtrl.Append(controlName);

          return wizard.FindControl(strCtrl.ToString());
        }

    }

}
