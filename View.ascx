<%@ Control Language="C#" Inherits="DotNetNuke.Modules.GreenupEnrollment.View" AutoEventWireup="true"
  CodeBehind="View.ascx.cs" %>
<%@ Register TagPrefix="dnn" TagName="Skin" Src="~/controls/SkinThumbNailControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="url" Src="~/controls/UrlControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<asp:Label ID="lblMessage" runat="server" CssClass="dnnFormMessage"></asp:Label>
<asp:Wizard ID="GreenupEnrollmentWizard" runat="server" 
  OnFinishButtonClick="OnFinishButtonClick"
  OnActiveStepChanged="OnActiveStepChanged" 
  DisplaySideBar="false" 
  CellPadding="5"
  CellSpacing="5" 
  CssClass="Wizard dnnForm" 
  ActiveStepIndex="0">
  <StepStyle VerticalAlign="Top" />
  <StepNavigationTemplate></StepNavigationTemplate>
  <HeaderTemplate>
    <asp:Label ID="lblTitle" CssClass="Head" runat="server"><% =DotNetNuke.Services.Localization.Localization.GetString(GreenupEnrollmentWizard.ActiveStep.Title + ".Title", this.LocalResourceFile)%></asp:Label><br />
    <br />
    <asp:Label ID="lblHelp" CssClass="WizardText" runat="server"><% =DotNetNuke.Services.Localization.Localization.GetString(GreenupEnrollmentWizard.ActiveStep.Title + ".Help", this.LocalResourceFile)%></asp:Label>
  </HeaderTemplate>
  <WizardSteps>
    <asp:WizardStep ID="wizIntroduction" runat="server" Title="Introduction" StepType="Start"
      AllowReturn="false">
      <p>
        This step is where introductory text should occur. This step's AllowReturn property
        is set to false, so after you leave this step you will not be able to return to
        it.</p>
        <div class="buttonContainer">
          <asp:LinkButton Visible="false" ID="PreviousButton_Intro" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Intro" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizProgramLocation" runat="server" Title="ProgramLocation" StepType="Step">
      <p>
        This step is where the customer chooses the program location.</p>
      <asp:DropDownList ID="ddlPrograms" runat="server" OnSelectedIndexChanged="ddlPrograms_SelectedIndexChanged">
        <asp:ListItem Text="Illinois" Value="Illinois" />
        <asp:ListItem Text="Pensylvania" Value="Pensylvania" />
      </asp:DropDownList>
        <div class="buttonContainer">
          <asp:LinkButton Visible="false" ID="PreviousButton_Loc" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Loc" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizProgramType" runat="server" Title="ProgramType" StepType="Auto">
      <p>
        This step is where the customer chooses between a Residential or Commercial program
        type.</p>
      <div id="ProgramTypeSelections">
        <asp:ImageButton ID="btnResidential" runat="server" ImageUrl="http://philadelphiagreenpower.com/portals/0/Images/residentialBuyButton-small.jpg"
          OnClick="btnResidential_Click" />
        <asp:ImageButton ID="btnCommercial" runat="server" ImageUrl="http://philadelphiagreenpower.com/portals/0/Images/BusinessEnroll-smalll.jpg"
          OnClick="btnCommercial_Click" />
      </div>
        <div class="buttonContainer">
          <asp:LinkButton Visible="false" ID="PreviousButton_Type" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton Visible="false" ID="NextButton_Type" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizResidentialProgram" runat="server" Title="ResidentialProgram"
      StepType="Step">
      <h2>
        Sterling Wind™</h2>
      <p>
        Did you know that most U.S. industrial air pollution comes from traditional electricity
        production? Your home electricity use is a major part of your carbon footprint.
        Fortunately, you can easily and affordably reduce your carbon emissions by enrolling
        for Sterling Wind™ <a>renewable energy certificates</a>, And while you’re benefiting
        the environment, you’ll also be doing your part for sustainability, USA-made energy,
        national independence from imported fuels and energy security. Start making a difference
        today by enrolling with Sterling Planet, ranked by the U.S. Environmental Protection
        Agency as the #1, large volume provider of renewable energy certificates. When you
        enroll, you’ll receive a welcome kit with a personalized Certificate of Environmental
        Stewardship to recognize your commitment.</p>
      <h3>
        How Does It Work?</h3>
      <p>
        When you buy Sterling Wind™, you enroll for renewable energy certificates (RECs)
        from projects that generate clean electricity using the power of natural wind resources.
        RECs represent all the environmental goodness of renewable energy production, such
        as avoided carbon emissions. RECs are sold separately from electricity, and so you’ll
        set up an account with Sterling Planet that’s in addition to the one you already
        have with an electricity provider. Priced at just 1¢ per kilowatt-hour, our wind
        RECs will cost as little as $5 per month, and do a world of good. Every 500 kWh
        of wind RECs avoids an estimated 4 metric tons of carbon dioxide emissions.</p>
      <p>
        <a>energy content label</a></p>
      <h3>
        Let’s Get Started</h3>
      <p>
        You can purchase RECs based on your home’s square footage, choosing a small, medium
        or large home. Or tell us how much electricity you use, and we’ll match 50% or 100%
        with RECs.</p>
      <p>
        Choose one:</p>
        <div class="RecChoiceHeader">
        <div class="sizeOfHomeHeader">Size of Home</div>
        <div class="percentOfUseHeader">Percentage of Electricity Use</div>
        </div>
      <asp:Panel ID="RecChoiceButtonPanel" CssClass="RecChoiceButtonPanel" runat="server">
        <div id="RecChoiceHome-S" class="recChoiceButton blockChoice">
          <asp:ImageButton ID="HomeImageButton_S" CssClass="homeImg" runat="server" />
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
          <asp:ImageButton ID="HomeImageButton_M" CssClass="homeImg" runat="server" />
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
          <asp:ImageButton ID="HomeImageButton_L" CssClass="homeImg" runat="server" />
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

      <!--
      <asp:RadioButtonList Visible="false" ID="rblResidentialSelection" runat="server" OnSelectedIndexChanged="rblResidentialSelection_SelectedIndexChanged"
        CssClass="rblResidentialSelection">
        <asp:ListItem Text="1 Block (500 kWh)" Value="500" />
        <asp:ListItem Text="2 Blocks (1000 kWh)" Value="1000" />
        <asp:ListItem Text="50% of your monthly kWh usage" Value="0.5" />
        <asp:ListItem Text="100% of your monthly kWh usage" Value="1" />
      </asp:RadioButtonList>
      <div id="ResidentialUsageAmount">
        <label for="ResidentialUsage">
          Enter your monthly power usage (kWh)</label>
        <input id="ResidentialUsage" type="text" size="8" value="500" />
      </div>
      -->

      <p class="userMsg">
        Your cost will be $<span id="ResidentialPrice">0</span> per month.</p>
        <div class="buttonContainer">
          <asp:LinkButton Visible="false" ID="PreviousButton_Res" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Res" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizCommercialProgram" runat="server" Title="CommercialProgram" StepType="Step">
<h2>Sterling Wind™</h2>
    <p>Sterling Planet provides <a href="#">renewable energy certificates</a> (RECs) to businesses and other organizations looking for meaningful, precise and verified ways to reduce
their environmental impact. The U.S. Environmental Protection Agency ranks Sterling Planet as the nation’s #1 REC provider, recognizing the company for
delivering more than 5 billion kilowatt-hours of RECs annually to members of the Green Power Partnership. The market leader, Sterling Planet caters to the
specific needs of organizations nationwide that have a commitment to sustainability and the economic bottom line.</p>
<h3>Our Services</h3>
<p>Sterling Planet delivers a comprehensive set of solutions to help our clients achieve their sustainability goals:</p>
<ul>
<li>Renewable energy certificates, all independently audited and certified</li>
<li>Carbon offsets representing verified emission reductions at certified projects</li>
<li>White Tags®, an innovative way to reward our clients’ energy efficiency</li>
<li>Green project investment and consulting services</li>
<li>GreenReach educational and enrollment outreach</li>
<li>Public relations, marketing and events services</li>
</ul>
<p>To learn more about Sterling Planet’s sustainability programs, contact us: <a href="mailto:info@sterlingplanet.com">info@sterlingplanet.com</a></p>
<h3>Benefits of Buying RECs</h3>
<p>More than ever, consumers expect businesses to care about the environment and about sustainability. Customer loyalty, retention and new referrals often grow
when companies show their commitment to the triple bottom line – people, planet and profit.</p>
<p>Signing up for RECs also has immediate <a href="#">benefits</a>:</p>
<ul>
<li>Personalized certificate and window cling to display at your business location</li>
<li>Public relations and marketing support to earn recognition with customers and other stakeholders</li>
<li>Assistance in joining the EPA Green Power Partnership</li>
</ul>
<h3>Let’s Get Started</h3>
<p>Sign up for wind RECs to match all or part of electricity used by your business or other organization. Our all-wind product is priced at just 1¢ per kilowatt-hour, and
large energy users can request a custom quote. <a href="#">energy content label</a></p> 
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
      ​
        <div class="buttonContainer">
          <asp:LinkButton Visible="false" ID="PreviousButton_Com" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Com" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizBillingInfo" Title="BillingInfo" runat="server">
      <!-- ... Put UI elements here ... -->
      First Name:<br />
      <asp:TextBox runat="server" ID="BillingFirstName" />
      <br />
      Last Name:<br />
      <asp:TextBox runat="server" ID="BillingLastName" />
      <br />
      E-mail Address:<br />
      <asp:TextBox runat="server" ID="EmailAddress" />
      <br />
      Phone:<br />
      <asp:TextBox runat="server" ID="BillingPhone" />
      <br />
      Address Line 1:
      <br />
      <asp:TextBox runat="server" ID="BillingAddressLine1" />
      <br />
      Address Line 2:
      <br />
      <asp:TextBox runat="server" ID="BillingAddressLine2" />
      <br />
      City:
      <br />
      <asp:TextBox runat="server" ID="BillingCity" />
      <br />
      State:
      <br />
      <asp:TextBox runat="server" ID="BillingState" />
      <br />
      ZIP Code:
      <br />
      <asp:TextBox runat="server" ID="BillingZipCode" />
      Name to Appear on Personalized Certificate:
      <br />
      <asp:TextBox runat="server" ID="CertificateName" />
      <br />
      <br />
      <asp:CheckBox runat="server" ID="BillingAcceptTerms" Text="I have read and agree to the terms of service." /><br />
      <asp:CheckBox runat="server" ID="AlternateContactCheckBox" Text="Please check here if you would like to add contact information that is different from your billing information." />
      <asp:Panel ID="BillingCaptcha" runat="server">
      <!--
        <dnn:captchacontrol id="ctlCaptcha" captchaheight="40" captchawidth="150" errorstyle-cssclass="NormalRed"
          cssclass="Normal" runat="server" errormessage="The typed code must match the image, please try again" />
          -->
      </asp:Panel>
        <div class="buttonContainer">
          <asp:LinkButton ID="PreviousButton_Bil" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Bil" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizAlternateContact" Title="AlternateContact" runat="server">
      <!-- Gather the alternate address in this step if CheckBox1 was selected. -->
      First Name:<br />
      <asp:TextBox runat="server" ID="AlternateFirstName" />
      <br />
      Last Name:<br />
      <asp:TextBox runat="server" ID="AlternateLastName" />
      <br />
      Phone:<br />
      <asp:TextBox runat="server" ID="AlternatePhone" />
      <br />
      Address Line 1:
      <br />
      <asp:TextBox runat="server" ID="AlternateAddress1" />
      <br />
      Address Line 2:
      <br />
      <asp:TextBox runat="server" ID="AlternateAddress2" />
      <br />
      City:
      <br />
      <asp:TextBox runat="server" ID="AlternateCity" />
      <br />
      State:
      <br />
      <asp:TextBox runat="server" ID="AlternateState" />
      <br />
      ZIP Code:
      <br />
      <asp:TextBox runat="server" ID="AlternateZipCode" />
        <div class="buttonContainer">
          <asp:LinkButton ID="PreviousButton_Alt" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Alt" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizFinish" Title="Finish" runat="server">
      <p>
        This is where payment information will be placed. Right now, the fields below are
        inactive, and the module is using test values for the credit card information.</p>
      <!-- Put UI elements here for the Finish step. -->
      Credit Card Number:<br />
      <asp:TextBox runat="server" ID="CardNumber" />
      <br />
      Expiration:<br />
      <asp:TextBox runat="server" ID="ExpirationMonth" Columns="2" />&nbsp;/&nbsp;
      <asp:TextBox runat="server" ID="ExpirationYear" Columns="2" />
        <div class="buttonContainer">
          <asp:LinkButton ID="PreviousButton_Fin" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Fin" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
    <asp:WizardStep ID="wizComplete" runat="server" Title="Complete" StepType="Complete">
      <p>
        This is where final information can be given to the customer. This should include
        a summary of the purchase that has just been made and instructions on how to contact
        the merchant regarding the subscription. The email function is not yet set up.</p>
      <asp:Label runat="server" ID="CompleteMessageLabel" Width="408px" Height="24px"></asp:Label>
      <asp:Literal ID="litResult" runat="server"></asp:Literal>
        <div class="buttonContainer">
          <asp:LinkButton ID="PreviousButton_Comp" runat="server" CausesValidation="False" CssClass="CommandButton PreviousBtn" CommandName="MovePrevious" Text="Previous" />
          <asp:LinkButton ID="NextButton_Comp" runat="server" CausesValidation="False" CssClass="CommandButton NextBtn" CommandName="MoveNext" Text="Next" />
        </div>
    </asp:WizardStep>
  </WizardSteps>
</asp:Wizard>
<input id="AnnualkWh" runat="server" type="hidden" />
<input id="KwhPrice" runat="server" type="hidden" />
<input id="MinPercent" runat="server" type="hidden" />
<input id="Percent" runat="server" type="hidden" />
<input id="AnnualPercent" runat="server" type="hidden" />
<input id="MonthCost" runat="server" type="hidden" />
<input id="ProgramType" runat="server" type="hidden" />
<input id="ProgramLocation" runat="server" type="hidden" />
