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
        private static string _postUrl = @"https://www.paypal.com/cgi-bin/webscr";


        #region Event Handlers

        private void Page_Init(object sender, System.EventArgs e)
        {
          if (!IsPostBack)
          {
            if (Request.QueryString["pr"] != null)
              GreenupEnrollmentWizard.ActiveStepIndex = Convert.ToInt32(Request.QueryString["pr"]);
          }
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
            lblMessage.Text = "param is " + v;
          }
          else
          {
            lblMessage.Text = "none";
          }

          if ((string)Settings["KwhPrice"] != "")
          {
            KwhPrice.Value = (string)Settings["KwhPrice"];
          }
            Page.ClientScript.RegisterClientScriptInclude(this.GetType(), "GreenupEnrollment", (this.TemplateSourceDirectory + "/JScript.js"));
            try
            {
              GreenupEnrollmentWizard.StartNextButtonText = Localization.GetString("Next", LocalResourceFile);
              GreenupEnrollmentWizard.StepNextButtonText = Localization.GetString("Next", LocalResourceFile);
              GreenupEnrollmentWizard.StepPreviousButtonText = Localization.GetString("Previous", LocalResourceFile);
              GreenupEnrollmentWizard.FinishPreviousButtonText = Localization.GetString("Previous", LocalResourceFile);
              GreenupEnrollmentWizard.FinishCompleteButtonText = Localization.GetString("Finish", LocalResourceFile);
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
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
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// The OnActiveStepChanged event is raised when the Wizard changes to a new step.
        /// </summary>
        /// -----------------------------------------------------------------------------
        protected void OnActiveStepChanged(object sender, EventArgs e)
        {
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

        /// -----------------------------------------------------------------------------
        ///<Summary>
        /// Handles click of Residential button
        ///</Summary>
        /// -----------------------------------------------------------------------------
        protected void btnResidential_Click(object sender, ImageClickEventArgs e)
        {
          GreenupEnrollmentWizard.ActiveStepIndex = 1;
          ProgramType.Value = "Residential";
        }

        /// -----------------------------------------------------------------------------
        ///<Summary>
        /// Handles click of Commercial button
        ///</Summary>
        /// -----------------------------------------------------------------------------
        protected void btnCommercial_Click(object sender, ImageClickEventArgs e)
        {
          GreenupEnrollmentWizard.ActiveStepIndex = 2;
          ProgramType.Value = "Commercial";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
          //Post back to either sandbox or live
          string strSandbox = "https://www.sandbox.paypal.com/cgi-bin/webscr";
          string strLive = "https://www.paypal.com/cgi-bin/webscr";
          HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strSandbox);

          //Set values for the request back
          req.Method = "POST";
          req.ContentType = "application/x-www-form-urlencoded";
          byte[] param = Request.BinaryRead(HttpContext.Current.Request.ContentLength);
          string strRequest = Encoding.ASCII.GetString(param);
          strRequest += "&cmd=_notify-validate";
          req.ContentLength = strRequest.Length;

          //for proxy
          //WebProxy proxy = new WebProxy(new Uri("http://url:port#"));
          //req.Proxy = proxy;

          //Send the request to PayPal and get the response
          StreamWriter streamOut = new StreamWriter(req.GetRequestStream(), System.Text.Encoding.ASCII);
          streamOut.Write(strRequest);
          streamOut.Close();
          StreamReader streamIn = new StreamReader(req.GetResponse().GetResponseStream());
          string strResponse = streamIn.ReadToEnd();
          streamIn.Close();

          if (strResponse == "VERIFIED")
          {
            //check the payment_status is Completed
            //check that txn_id has not been previously processed
            //check that receiver_email is your Primary PayPal email
            //check that payment_amount/payment_currency are correct
            //process payment


            //PaypalPaymentHistory PPH = new PaypalPaymentHistory();

            //PPH.LastName = HttpContext.Current.Request["last_name"];
            //PPH.FirstName = HttpContext.Current.Request["first_name"];
            //PPH.State = HttpContext.Current.Request["address_state"];
            //PPH.Zipcode = HttpContext.Current.Request["address_zip"];
            //PPH.Address = HttpContext.Current.Request["address_street"];
            //PPH.UserName = HttpContext.Current.Request["option_name2"];
            //PPH.PaymentStatus = HttpContext.Current.Request["payment_status"];
            //PPH.SelectedPackage = HttpContext.Current.Request["option_selection1"];
            //PPH.PayerStatus = HttpContext.Current.Request["payer_status"];
            //PPH.PaymentType = HttpContext.Current.Request["payment_type"];
            //PPH.PayerEmail = HttpContext.Current.Request["payer_email"];
            //PPH.ReceiverId = HttpContext.Current.Request["receiver_id"];
            //PPH.TxnType = HttpContext.Current.Request["txn_type"];
            //PPH.PaymentGross = HttpContext.Current.Request["payment_gross"];

            //PPH.Insert();
          }
          else if (strResponse == "INVALID")
          {
            //log for manual investigation
          }
          else
          {
            //log response/ipn data for manual investigation
          }
        }
    }
  }
