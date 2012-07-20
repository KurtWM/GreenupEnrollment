<%@ Control Language="C#" CodeFile="View.ascx.cs" Inherits="DotNetNuke.Modules.GreenupEnrollment.View"
  AutoEventWireup="true" %>
<%@ Register TagPrefix="dnn" TagName="Skin" Src="~/controls/SkinThumbNailControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="url" Src="~/controls/UrlControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<asp:Label ID="lblMessage" runat="server" CssClass="dnnFormMessage"></asp:Label>
<asp:Wizard ID="GreenupEnrollmentWizard" runat="server" OnFinishButtonClick="OnFinishButtonClick"
  OnActiveStepChanged="OnActiveStepChanged" DisplaySideBar="false" CellPadding="5"
  CellSpacing="5" CssClass="Wizard dnnForm" ActiveStepIndex="0">
  <StepStyle VerticalAlign="Top" />
  <StepNavigationTemplate>
  </StepNavigationTemplate>
  <FinishCompleteButtonStyle CssClass="CommandButton" />
  <HeaderTemplate>
    <asp:Label ID="lblTitle" CssClass="Head" runat="server"><% =DotNetNuke.Services.Localization.Localization.GetString(GreenupEnrollmentWizard.ActiveStep.Title + ".Title", this.LocalResourceFile)%></asp:Label>
    <asp:Label ID="lblHelp" CssClass="WizardText" runat="server"><% =DotNetNuke.Services.Localization.Localization.GetString(GreenupEnrollmentWizard.ActiveStep.Title + ".Help", this.LocalResourceFile)%></asp:Label>
  </HeaderTemplate>
  <WizardSteps>
    <asp:WizardStep ID="wizProgramType" runat="server" Title="ProgramType" StepType="Start">
      <h2 class="century-gothic">
        <span class="hdr">Let's Get Started</span></h2>
      <p>
        Renewable Energy Certificates (REC)s are for individuals, businesses and organizations
        looking for an easy and reliable way to estimate and reduce their impact on the
        environment. Join us and start reducing your impact on the environment today!</p>
      <div id="ProgramTypeSelections">
        <asp:ImageButton ID="btnResidential" runat="server" ImageUrl="http://philadelphiagreenpower.com/portals/0/Images/residentialBuyButton-small.jpg"
          OnClick="btnResidential_Click" />
        <p>
          Offset your day-to-day activities like driving, flying and using energy at home.</p>
        <asp:ImageButton ID="btnCommercial" runat="server" ImageUrl="http://philadelphiagreenpower.com/portals/0/Images/BusinessEnroll-smalll.jpg"
          OnClick="btnCommercial_Click" />
        <p>
          Accurately calculate and reduce your business' impact on the environment.</p>
      </div>
      <div class="buttonContainer">
        <asp:LinkButton Visible="false" ID="PreviousButton_Type" runat="server" CausesValidation="False"
          CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
        <asp:LinkButton Visible="false" ID="NextButton_Type" runat="server" CausesValidation="False"
          CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
      </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizResidentialProgram" runat="server" Title="ResidentialProgram"
      StepType="Step" AllowReturn="False">
      <h3 class="century-gothic">
        <span class="hdr">Let's Get Started</span></h3>
      <p>
        You can purchase RECs based on your home's square footage, choosing a small, medium
        or large home. Or tell us how much electricity you use, and we'll match 50% or 100%
        with RECs.</p>
      <p>
        Choose one:</p>
      <div class="RecChoiceHeader">
        <div class="sizeOfHomeHeader">
          Size of Home</div>
        <div class="percentOfUseHeader">
          Percentage of Electricity Use</div>
      </div>
      <asp:Panel ID="RecChoiceButtonPanel" CssClass="RecChoiceButtonPanel" runat="server">
        <div id="RecChoiceHome-S" class="recChoiceButton blockChoice">
          <asp:Image ID="HomeImage_S" runat="server" CssClass="homeImg" />
          <p class="recChoiceTitle">
            Small Home or Apartment
            <br />
            less than 1,000 sq ft</p>
          <p class="recChoiceDesc">
            Match 500 kWh
            <br />
            per month<br />
            @ 1¢ per kWh<br />
            $5.00 monthly</p>
          <input type="hidden" class="monthlyPower" value="500" /></div>
        <input class="multiplier" type="hidden" value="1.0" />
        <div id="RecChoiceHome-M" class="recChoiceButton blockChoice">
          <asp:Image ID="HomeImage_M" CssClass="homeImg" runat="server" />
          <p class="recChoiceTitle">
            Medium Home
            <br />
            approximately 2,000 sq ft</p>
          <p class="recChoiceDesc">
            Match 1,000 kWh
            <br />
            per month<br />
            @ 1¢ per kWh<br />
            $10.00 monthly</p>
          <input type="hidden" class="monthlyPower" value="1000" /></div>
        <input class="multiplier" type="hidden" value="1.0" />
        <div id="RecChoiceHome-L" class="recChoiceButton blockChoice">
          <asp:Image ID="HomeImage_L" CssClass="homeImg" runat="server" />
          <p class="recChoiceTitle">
            Large Home
            <br />
            approximately 3,000 sq ft</p>
          <p class="recChoiceDesc">
            Match 1,500 kWh
            <br />
            per month<br />
            @ 1¢ per kWh<br />
            $15.00 monthly</p>
          <input type="hidden" class="monthlyPower" value="1500" /></div>
        <input class="multiplier" type="hidden" value="1.0" />
        <div id="RecChoiceHome-100" class="recChoiceButton percentChoice">
          <div class="largePercent">
            100%</div>
          <p class="recChoiceDesc">
            Match 100% of electricity
            <br />
            use with wind energy
            <br />
            @ 1&cent; per kWh</p>
          <p class="recChoiceDesc recChoiceMoPower">
            Enter your monthly
            <br />
            power usage (kWh)</p>
          <input id="monthlyPower100" class="monthlyPower" type="text" size="5" />
          <input class="multiplier" type="hidden" value="1.0" />
          <p class="recChoiceDesc amount">
            $<span id="monthlyPowerDisplay-100" class="powerDisplay">xx.xx</span> monthly</p>
        </div>
        <div id="RecChoiceHome-50" class="recChoiceButton percentChoice">
          <div class="largePercent">
            50%</div>
          <p class="recChoiceDesc">
            Match 50% of electricity
            <br />
            use with wind energy
            <br />
            @ 1&cent; per kWh</p>
          <p class="recChoiceDesc recChoiceMoPower">
            Enter your monthly
            <br />
            power usage (kWh)</p>
          <input id="monthlyPower50" class="monthlyPower" type="text" size="5" />
          <input class="multiplier" type="hidden" value="0.5" />
          <p class="recChoiceDesc amount">
            $<span id="monthlyPowerDisplay-50" class="powerDisplay">xx.xx</span> monthly</p>
        </div>
      </asp:Panel>
      <p class="userMsg">
        Your cost will be $<span id="ResidentialPrice">0</span> per month.</p>
      <div class="buttonContainer">
        <asp:LinkButton Visible="false" ID="PreviousButton_Res" runat="server" CausesValidation="False"
          CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
        <asp:LinkButton ID="NextButton_Res" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn"
          CommandName="MoveNext" Text="Next" />
      </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizCommercialProgram" runat="server" Title="CommercialProgram"
      StepType="Step" AllowReturn="False">
      <h3 class="century-gothic">
        <span class="hdr">Let's Get Started</span></h3>
      <p>
        Sign up for wind RECs to match all or part of electricity used by your business
        or other organization. Our all-wind product is priced at just <asp:Label ID="kWhPriceMsgLabel" runat="server">1</asp:Label>¢ per kilowatt-hour,
        and large energy users can request a custom quote.</p>
      <div id="SterlingCommercialEnrollment">
        <div class="SectionHead">
          What is your average annual electricity use?</div>
        <label for="Annual_kWh">
          Annual kWh:
        </label>
        <input id="Annual_kWh" name="Annual_kWh" type="text" size="8" />
        <div id="PercentSelectSlider" style="display: none;">
          <div class="SectionHead">
            What percentage of your electricity use would you like to match with clean energy?</div>
          <div id="valueMarker">
            <span>0%</span></div>
          <div id="slider">
          </div>
          <div id="markers">
            <span id="lowMarker">0%</span> <span id="highMarker">100%</span> <span id="totalLabel">
            </span>
          </div>
          <div class="EndNote">
            To qualify for the EPA Green Power Partnership, match at least 20% of electricity
            use with clean energy.</div>
        </div>
        <div id="RequestQuoteMsg" style="display: none;">
          As a large energy user, you may qualify for a volume discount. Please <a href="#">
            request a quote</a>.</div>
      </div>
      <div class="buttonContainer">
        <asp:LinkButton Visible="false" ID="PreviousButton_Com" runat="server" CausesValidation="False"
          CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
        <asp:LinkButton ID="NextButton_Com" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn"
          CommandName="MoveNext" Text="Next" />
      </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizBillingInfo" Title="BillingInfo" runat="server" StepType="Finish">
      <asp:ValidationSummary ID="ValidationSummary1" HeaderText="You must enter a value in the following fields:"
        DisplayMode="BulletList" EnableClientScript="true" runat="server" />
      <fieldset>
        <legend>Contact Information</legend>
        <p>
          <b>Bold</b> fields are required.</p>
        <div id="BillingContactContainer" class="innerContainer">
          <h3>
            Billing Contact Information</h3>
          <label for="BillingFirstName" class="required">
            First Name:</label>
          <asp:TextBox runat="server" ID="BillingFirstName" name="BillingFirstName" TabIndex="1" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name"
            Text="*" ControlToValidate="BillingFirstName"></asp:RequiredFieldValidator>
          <br />
          <label for="BillingFirstName" class="required">
            Last Name:</label>
          <asp:TextBox runat="server" ID="BillingLastName" name="BillingLastName" TabIndex="2" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last Name"
            Text="*" ControlToValidate="BillingLastName"></asp:RequiredFieldValidator>
          <br />
          <label for="EmailAddress" class="required">
            E-mail Address:</label>
          <asp:TextBox runat="server" ID="EmailAddress" name="EmailAddress" TabIndex="3" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email"
            Text="*" ControlToValidate="EmailAddress"></asp:RequiredFieldValidator>
          <br />
          <label for="BillingPhone" class="required">
            Phone:</label>
          <asp:TextBox runat="server" ID="BillingPhone" name="BillingPhone" Rows="15" MaxLength="20"
            TabIndex="4" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Phone"
            Text="*" ControlToValidate="BillingPhone"></asp:RequiredFieldValidator>
          <br />
          <label for="BillingAddressLine1" class="required">
            Address Line 1:</label>
          <asp:TextBox runat="server" ID="BillingAddressLine1" name="BillingAddressLine1" Rows="50"
            MaxLength="60" TabIndex="5" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Address"
            Text="*" ControlToValidate="BillingAddressLine1"></asp:RequiredFieldValidator>
          <br />
          <small>Street address, P.O. box, company name, c/o</small>
          <label for="BillingAddressLine2">
            Address Line 2:</label>
          <asp:TextBox runat="server" ID="BillingAddressLine2" name="BillingAddressLine2" Rows="50"
            MaxLength="60" />
          <br />
          <small>Apartment, suite, unit, building, floor, etc.</small>
          <label for="BillingCity" class="required">
            City:</label>
          <asp:TextBox runat="server" ID="BillingCity" name="BillingCity" Rows="25" MaxLength="50"
            TabIndex="6" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="City"
            Text="*" ControlToValidate="BillingCity"></asp:RequiredFieldValidator>
          <br />
          <label for="ddlBillingStates" class="required">
            State/Province/Region:</label>
          <asp:DropDownList ID="ddlBillingStates" name="ddlBillingStates" runat="server" TabIndex="7">
          </asp:DropDownList>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="State/Province/Region"
            Text="*" ControlToValidate="ddlBillingStates"></asp:RequiredFieldValidator>
          <br />
          <label for="BillingZipCode" class="required">
            ZIP Code:</label>
          <asp:TextBox runat="server" ID="BillingZipCode" name="BillingZipCode" Rows="20" MaxLength="20"
            TabIndex="8" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Zip Code"
            Text="*" ControlToValidate="BillingZipCode"></asp:RequiredFieldValidator>
          <br />
          <span class="checkbox">
            <input type="checkbox" id="cbDisplayAltContact" tabindex="9" />
            <label for="cbDisplayAltContact">
              Please check here if you would like to add contact information that is different
              from your billing information</label>
          </span>
          <div id="AlternateContactContainer">
            <h3>
              Alternate Contact Information</h3>
            <label for="AlternateFirstName">
              First Name:</label>
            <asp:TextBox runat="server" ID="AlternateFirstName" name="AlternateFirstName" TabIndex="10" />
            <br />
            <label for="AlternateLastName">
              Last Name:</label>
            <asp:TextBox runat="server" ID="AlternateLastName" name="AlternateLastName" TabIndex="11" />
            <br />
            <label for="AlternateEmail">
              Email:</label>
            <asp:TextBox runat="server" ID="AlternateEmail" name="AlternateEmail" TabIndex="12" />
            <br />
            <label for="AlternatePhone">
              Phone:</label>
            <asp:TextBox runat="server" ID="AlternatePhone" name="AlternatePhone" Rows="15" MaxLength="20"
              TabIndex="13" />
            <br />
            <label for="AlternateAddress1">
              Address Line 1:</label>
            <asp:TextBox runat="server" ID="AlternateAddress1" name="AlternateAddress1" TabIndex="14" />
            <br />
            <small>Street address, P.O. box, company name, c/o</small>
            <label for="AlternateAddress2">
              Address Line 2:</label>
            <asp:TextBox runat="server" ID="AlternateAddress2" name="AlternateAddress2" TabIndex="15" />
            <br />
            <small>Apartment, suite, unit, building, floor, etc.</small>
            <label for="AlternateCity">
              City:</label>
            <asp:TextBox runat="server" ID="AlternateCity" name="AlternateCity" Rows="25" MaxLength="50"
              TabIndex="16" />
            <br />
            <label for="ddlAlternateStates">
              State/Province/Region:</label>
            <asp:DropDownList runat="server" ID="ddlAlternateStates" name="ddlAlternateStates"
              TabIndex="17">
            </asp:DropDownList>
            <br />
            <label for="AlternateZipCode">
              ZIP Code:</label>
            <asp:TextBox runat="server" ID="AlternateZipCode" name="AlternateZipCode" MaxLength="20"
              Rows="20" TabIndex="18" />
          </div>
        </div>
      </fieldset>
      <fieldset>
        <legend>Credit Card Information</legend>
        <div id="PaymentInfoContainer" class="innerContainer">
          <p>
            [default values are for testing only]</p>
          <label for="CardNumber" class="required">
            Credit Card Number:</label>
          <asp:TextBox runat="server" ID="CardNumber" name="CardNumber" TabIndex="19" Text="4111111111111111" />
          <br />
          <label class="required">
            Expiration:</label>
          <asp:TextBox runat="server" ID="ExpirationMonth" Columns="2" TabIndex="20" Text="07" />&nbsp;/&nbsp;
          <asp:TextBox runat="server" ID="ExpirationYear" Columns="2" TabIndex="21" Text="2020" />
        </div>
        <div id="BillingCaptchaContainer" class="innerContainer">
          <asp:Panel ID="BillingCaptcha" runat="server">
            <dnn:CaptchaControl ID="ctlCaptcha" CaptchaHeight="40" CaptchaWidth="150" ErrorStyle-CssClass="NormalRed"
              CssClass="Normal" runat="server" ErrorMessage="The typed code must match the image, please try again" />
          </asp:Panel>
        </div>
        <div id="AcceptTermsContainer" class="innerContainer">
          <asp:CheckBox runat="server" ID="BillingAcceptTerms" name="BillingAcceptTerms" CssClass="checkbox"
            Text="I have read and agree to the <a href='#'>terms of service</a>." TabIndex="22" />
          <asp:CustomValidator ID="AcceptTermsRequired" runat="server" EnableClientScript="true"
            OnServerValidate="AcceptTermsRequired_ServerValidate" OnClientValidate="AcceptTermsRequired_ClientValidate"
            ErrorMessage="Accept Terms checkbox" Text="*">*</asp:CustomValidator>
        </div>
      </fieldset>
      <div class="buttonContainer">
        <asp:LinkButton ID="PreviousButton_Bil" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn"
          CommandName="MovePrevious" Text="Previous" Visible="False" />
        <asp:LinkButton ID="NextButton_Bil" runat="server" CausesValidation="true" CssClass="CommandButton NextBtn"
          CommandName="MoveNext" Text="Submit" Visible="False" />
      </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizComplete" Title="Complete" runat="server" StepType="Complete">
      <asp:Label ID="tempLabel" runat="server" CssClass="dnnFormMessage"></asp:Label>
    </asp:WizardStep>
  </WizardSteps>
</asp:Wizard>
<input id="KwhPrice" runat="server" type="hidden" />
<input id="AnnualkWh" runat="server" type="hidden" />
<input id="MonthkWh" runat="server" type="hidden" />
<input id="MinPercent" runat="server" type="hidden" />
<input id="Percent" runat="server" type="hidden" />
<input id="AnnualPercent" runat="server" type="hidden" />
<input id="MonthCost" runat="server" type="hidden" />
<input id="ProgramType" runat="server" type="hidden" />
<input id="RefId" runat="server" type="hidden" />
<!--<input id="ProgramLocation" runat="server" type="hidden" />-->
