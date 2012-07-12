<%@ Control Language="C#" Inherits="DotNetNuke.Modules.GreenupEnrollment.View" AutoEventWireup="true"
  CodeBehind="View.ascx.cs" %>
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
      StepType="Step">
      <p>
        Did you know that most U.S. industrial air pollution comes from traditional electricity
        production? Your home electricity use is a major part of your carbon footprint.
        Fortunately, you can easily and affordably reduce your carbon emissions by enrolling
        for Sterling Wind™ <a>renewable energy certificates</a>, And while you're benefiting
        the environment, you'll also be doing your part for sustainability, USA-made energy,
        national independence from imported fuels and energy security. Start making a difference
        today by enrolling with Sterling Planet, ranked by the U.S. Environmental Protection
        Agency as the #1, large volume provider of renewable energy certificates. When you
        enroll, you'll receive a welcome kit with a personalized Certificate of Environmental
        Stewardship to recognize your commitment.</p>
      <h3 class="century-gothic">
        <span class="hdr">How Does It Work?</span></h3>
      <p>
        When you buy Sterling Wind™, you enroll for renewable energy certificates (RECs)
        from projects that generate clean electricity using the power of natural wind resources.
        RECs represent all the environmental goodness of renewable energy production, such
        as avoided carbon emissions. RECs are sold separately from electricity, and so you'll
        set up an account with Sterling Planet that's in addition to the one you already
        have with an electricity provider. Priced at just 1¢ per kilowatt-hour, our wind
        RECs will cost as little as $5 per month, and do a world of good. Every 500 kWh
        of wind RECs avoids an estimated 4 metric tons of carbon dioxide emissions.</p>
      <p>
        <a href="http://www.philadelphiagreenpower.com/Portals/0/assets/downloads/SterlingWindContentLabel.pdf"
          target="_blank">energy content label</a></p>
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
          <asp:ImageButton ID="HomeImageButton_S" CssClass="homeImg" runat="server" CausesValidation="False" />
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
      StepType="Step">
      <p>
        Sterling Planet provides <a href="#">renewable energy certificates</a> (RECs) to
        businesses and other organizations looking for meaningful, precise and verified
        ways to reduce their environmental impact. The U.S. Environmental Protection Agency
        ranks Sterling Planet as the nation's #1 REC provider, recognizing the company for
        delivering more than 5 billion kilowatt-hours of RECs annually to members of the
        Green Power Partnership. The market leader, Sterling Planet caters to the specific
        needs of organizations nationwide that have a commitment to sustainability and the
        economic bottom line.</p>
      <h3 class="century-gothic">
        <span class="hdr">Our Services</span></h3>
      <p>
        Sterling Planet delivers a comprehensive set of solutions to help our clients achieve
        their sustainability goals:</p>
      <ul>
        <li>Renewable energy certificates, all independently audited and certified</li>
        <li>Carbon offsets representing verified emission reductions at certified projects</li>
        <li>White Tags®, an innovative way to reward our clients' energy efficiency</li>
        <li>Green project investment and consulting services</li>
        <li>GreenReach educational and enrollment outreach</li>
        <li>Public relations, marketing and events services</li>
      </ul>
      <p>
        To learn more about Sterling Planet's sustainability programs, contact us: <a href="mailto:info@sterlingplanet.com">
          info@sterlingplanet.com</a></p>
      <h3 class="century-gothic">
        <span class="hdr">Benefits of Buying RECs</span></h3>
      <p>
        More than ever, consumers expect businesses to care about the environment and about
        sustainability. Customer loyalty, retention and new referrals often grow when companies
        show their commitment to the triple bottom line – people, planet and profit.</p>
      <p>
        Signing up for RECs also has immediate <a href="#">benefits</a>:</p>
      <ul>
        <li>Personalized certificate and window cling to display at your business location</li>
        <li>Public relations and marketing support to earn recognition with customers and
          other stakeholders</li>
        <li>Assistance in joining the EPA Green Power Partnership</li>
      </ul>
      <h3 class="century-gothic">
        <span class="hdr">Let's Get Started</span></h3>
      <p>
        Sign up for wind RECs to match all or part of electricity used by your business
        or other organization. Our all-wind product is priced at just 1¢ per kilowatt-hour,
        and large energy users can request a custom quote.</p>
      <p>
        <a href="http://www.philadelphiagreenpower.com/Portals/0/assets/downloads/SterlingWindContentLabel.pdf"
          target="_blank">energy content label</a></p>
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
      ​<asp:CheckBox runat="server" ID="CheckBox1" Text="I have read and agree to the terms of service." />
    <!-- Display the PayPal payment button. -->  
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" 
        OnClick="SubmitButton_Click" />
    <input type="image" name="submit" border="0"  
        src="https://www.paypal.com/en_US/i/btn/btn_subscribe_LG.gif"  
        alt="PayPal - The safer, easier way to pay online" />  
    <img alt="" border="0" width="1" height="1"  
        src="https://www.paypal.com/en_US/i/scr/pixel.gif" />  
    </asp:WizardStep>
  </WizardSteps>
</asp:Wizard>
<input id="KwhPrice" runat="server" type="hidden" />
<input id="AnnualkWh" runat="server" type="hidden" />
<input id="MinPercent" runat="server" type="hidden" />
<input id="Percent" runat="server" type="hidden" />
<input id="AnnualPercent" runat="server" type="hidden" />
<input id="MonthCost" runat="server" type="hidden" />
<input id="ProgramType" runat="server" type="hidden" />
<!--<input id="ProgramLocation" runat="server" type="hidden" />-->

  
    <!-- Identify your business so that you can collect the payments. -->  
    <input type="hidden" name="business" value="kurt.m_1341980594_biz@gmail.com" />  
  
    <!-- Specify a Subscribe button. -->  
    <input type="hidden" name="cmd" value="_xclick-subscriptions" />  
  
    <!-- Identify the subscription. -->  
    <input type="hidden" name="item_name" value="this is a test subscription" />  
    <input type="hidden" name="item_number" value="Sterling Planet" />  
    <input type="hidden" name="custom" value="" />  

    <!-- Do not prompt buyers to include a note with their payments. -->
    <input type="hidden" name="no_note" value="1" />  
  
    <!-- Set the terms of the regular subscription. -->  
    <input type="hidden" name="currency_code" value="USD" />  
    <input type="hidden" name="a3" value="5.00" />  
    <input type="hidden" name="p3" value="1" />  
    <input type="hidden" name="t3" value="M" />  
  
    <!-- Set recurring payments until canceled. -->  
    <input type="hidden" name="src" value="1" />  
  


