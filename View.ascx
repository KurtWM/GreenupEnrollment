<%@ Control Language="C#" Inherits="DotNetNuke.Modules.GreenupEnrollment.View" AutoEventWireup="true" Codebehind="View.ascx.cs" %>

<%@ Register TagPrefix="dnn" TagName="Skin" Src="~/controls/SkinThumbNailControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="url" Src="~/controls/UrlControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>

<asp:Label ID="testingLabel" runat="server"></asp:Label>
<asp:Label ID="lblMessage" runat="server" CssClass="dnnFormMessage"></asp:Label>
<asp:Wizard ID="GreenupEnrollmentWizard" runat="server" 
  OnActiveStepChanged="OnActiveStepChanged" 
  DisplaySideBar="false" 
  CellPadding="5"
  CellSpacing="5" 
  CssClass="Wizard dnnForm" 
  ActiveStepIndex="0" 
  NavigationButtonStyle-CssClass="CommandButton">
  <WizardSteps>
    <asp:WizardStep ID="wizProgramType" runat="server" Title="ProgramType" StepType="Step" AllowReturn="False">
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
          CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" 
          OnClick="NextButton_Type_Click" />
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
          <input type="hidden" class="monthlyPower" value="500" />
        <input class="multiplier" type="hidden" value="1.0" />
        </div>
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
          <input type="hidden" class="monthlyPower" value="1000" />
        <input class="multiplier" type="hidden" value="1.0" />
        </div>
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
          <input type="hidden" class="monthlyPower" value="1500" />
        <input class="multiplier" type="hidden" value="1.0" />
        </div>
        <div id="RecChoiceHome-100" class="recChoiceButton percentChoice">
          <asp:Image ID="HomeImage_100" CssClass="homeImg" runat="server" />
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
          <asp:Image ID="HomeImage_50" CssClass="homeImg" runat="server" />
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
        <asp:LinkButton ID="NextButton_Res" runat="server" 
          CausesValidation="False" 
          CssClass="CommandButton NextBtn ResSubmit"
          style="display: none;"
          CommandName="MoveNext" 
          Text="Next" />
      </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizCommercialProgram" runat="server" Title="CommercialProgram"
      StepType="Step" AllowReturn="False">
      <h3 class="century-gothic">
        <span class="hdr">Let's Get Started</span></h3>
      <p>
        Sign up for wind RECs to match all or part of electricity used by your business
        or other organization. Our all-wind product is priced per kilowatt-hour,
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
    <asp:WizardStep ID="wizBillingInfo" Title="BillingInfo" runat="server" StepType="Step">
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
          <br />
          <label class="required">
            CSV:</label>
          <asp:TextBox runat="server" ID="CardCode" Columns="2" TabIndex="22" Text="123" />
        </div>
        <div id="InvoiceMeContainer" class="innerContainer">
          <asp:CheckBox ID="InvoiceMeCheckBox" runat="server" 
            CssClass="checkbox floatLeft"
            TabIndex="23" />
            <div class="checkbox">Invoice me.</div>
        </div>
        <div id="AcceptTermsContainer" class="innerContainer">
          <asp:CheckBox ID="BillingAcceptTerms" runat="server" 
            name="BillingAcceptTerms" 
            CssClass="checkbox floatLeft" 
            TabIndex="24" />
            <div class="checkbox">I have read and agree to the <a id="showTerms" href="javascript:void(0);">terms of service</a>.</div>
          <asp:CustomValidator ID="AcceptTermsRequired" runat="server" 
            EnableClientScript="true" 
            OnServerValidate="AcceptTermsRequired_ServerValidate" 
            ClientValidationFunction="AcceptTermsRequired_ClientValidate" 
            ErrorMessage="You must accept the terms to proceed." 
            Text="*"></asp:CustomValidator>
        </div>
        <asp:Panel ID="BillingCaptchaPanel" runat="server" Visible="false">
          <dnn:CaptchaControl ID="dnnCaptchaControl" runat="server" ErrorStyle-CssClass="NormalRed" CssClass="Normal" ErrorMessage="The typed code must match the image, please try again" CaptchaHeight="35" CaptchaWidth="120" />
        </asp:Panel>
      </fieldset>
      <div class="buttonContainer">
        <asp:LinkButton ID="PreviousButton_Bil" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn"
          CommandName="MovePrevious" Text="Previous" Visible="False" />
        <asp:LinkButton ID="NextButton_Bil" runat="server" 
          CausesValidation="false" 
          CommandName="MoveNext" 
          CssClass="CommandButton NextBtn"
          Text="Submit" OnClick="NextButton_Bil_Click" />
      </div>
      <div id="terms" style="display:none;">
        <p>
          This product supports electricity production from new wind energy facilities nationwide.
          This is not an electricity purchase, but a purchase of renewable energy certificates
          (RECs). Sold separately from electrical output, RECs represent all the environmental
          benefits of electricity production using renewable resources such as wind, solar,
          and small hydro.
        </p>
        <p>
          When you enroll, you stay with your current electric utility. You continue to pay
          your regular electric bill, plus an additional amount for your purchase of this
          REC product.
        </p>
        <p>
          By enrolling, you make a difference. The positive effects include the following:
          (1) guarantees that clean, zero-emissions renewable energy has been delivered to
          the electric grid, replacing conventional electricity and lowering greenhouse gas
          emissions, and (2) support for clean, USA-made energy that is beneficial to human
          health, the overall environment and national and local economies.
        </p>
        <p>
          This product is provided through Sterling Planet, a leading national provider of
          RECs and other clean energy solutions. Sterling Planet's supply is Green-e Energy
          certified, with this product meeting the environmental and consumer protection standards
          established by the nonprofit Center for Resource Solutions. See the 
          <asp:HyperLink ID="EnergyContentHyperLink" runat="server" Target="_blank">Energy Content Label</asp:HyperLink>
          for further details.
        </p>
        <p>
          You may increase, decrease or cancel your wind energy purchase at any time without
          any fees or other penalties. To change or cancel your account, simply call Sterling
          Planet at 1-877-457-2306. You may also write a letter requesting to cancel your
          account, addressed to Sterling Planet at 3500 Parkway Lane, Suite 500, Norcross,
          GA, 30092.
        </p>
      </div>
   </asp:WizardStep>
    <asp:WizardStep ID="wizComplete" Title="Complete" runat="server" StepType="Complete">
        <h2>
          Thanks for choosing sustainable energy!</h2>
        <p>
          Starting today, you're making a real difference. Every 1,000 kilowatt-hours of renewable
          energy you purchase mitigates about 1,500 pounds of carbon dioxide emissions. Over
          the course of a year, the environmental benefits really add up. They compare to
          <strong>not driving</strong> nearly 19,000 miles in the average vehicle or <strong>
            not using</strong> 928 gallons of gasoline.</p>
        <p>
          You've made the clear energy choice for a stronger economy too. Putting more USA-made
          energy to work creates more new "green" jobs, generates more state and local tax
          revenue, and increases our nation's energy diversity and independence from imported
          fuels.
        </p>
        <p>
          Thanks again for taking a real, meaningful step toward sustainability – for the
          environment and the economy. Please look for automatic email notification of your
          enrollment. And in the next few days, you'll also receive a personalized <em>Certificate
            of Sustainable Energy</em>.</p>
        <p>
          In the meantime, here's how we show your account:</p>
        <p>
          <strong>Enrollment:<br />
          </strong><asp:Label ID="FirstNameLabel" runat="server" />&nbsp;<asp:Label ID="LastNameLabel" runat="server" /><br />
          <asp:Label ID="Address1Label" runat="server" /><br />
          <asp:Label ID="Address2Label" runat="server" /><br />
          <asp:Label ID="CityLabel" runat="server" />, <asp:Label ID="StateLabel" runat="server" /> <asp:Label ID="ZipLabel" runat="server" /><br />
          <asp:Label ID="EmailLabel" runat="server" />
          <br />
          <asp:Label ID="PhoneLabel" runat="server" /></p>
        <p>
          <strong>Product:<br />
          </strong>Sterling Wind™<br />
          <asp:Label ID="kWhLabel" runat="server" /> kWh <asp:Label ID="TermLabel" runat="server" /> @ <asp:Label ID="kWhUnitPriceLabel" runat="server" /></p>
        <p>
          <strong>Billing:<br />
          </strong>Credit card: <asp:Label ID="CardNumberLabel" runat="server" />
          <br />
          <asp:Label ID="MonthlyPriceLabel" runat="server" /> per month</p>
      <asp:Label ID="tempLabel" runat="server" CssClass="dnnFormMessage"></asp:Label>
    </asp:WizardStep>
  </WizardSteps>
  <NavigationButtonStyle />
  <StepStyle VerticalAlign="Top" />
  <StepNavigationTemplate>
  </StepNavigationTemplate>
  <FinishCompleteButtonStyle CssClass="CommandButton" />
  <FinishPreviousButtonStyle CssClass="CommandButton" />
  <HeaderTemplate>
    <asp:Label ID="lblTitle" CssClass="Head" runat="server"><% =DotNetNuke.Services.Localization.Localization.GetString(GreenupEnrollmentWizard.ActiveStep.Title + ".Title", this.LocalResourceFile)%></asp:Label>
    <asp:Label ID="lblHelp" CssClass="WizardText" runat="server"><% =DotNetNuke.Services.Localization.Localization.GetString(GreenupEnrollmentWizard.ActiveStep.Title + ".Help", this.LocalResourceFile)%></asp:Label>
  </HeaderTemplate>
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
