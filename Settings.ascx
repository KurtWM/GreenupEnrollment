<%@ Control Language="C#" AutoEventWireup="false" Inherits="DotNetNuke.Modules.GreenupEnrollment.Settings" Codebehind="Settings.ascx.cs" %>




<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %>

	<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"><%=LocalizeString("BasicSettings")%></a></h2>
	<fieldset>
        <div class="dnnFormItem">
          <dnn:Label ID="KwhPriceLabel" runat="server" ControlName="txtKwhPrice" Suffix=":"></dnn:Label>
            <asp:TextBox ID="txtKwhPrice" runat="server" />
        </div>
        <div class="dnnFormItem">
          <dnn:Label ID="SubscriptonNameLabel" runat="server" ControlName="txtSubscriptonName" Suffix=":"></dnn:Label>
            <asp:TextBox ID="txtSubscriptonName" runat="server" MaxLength="50" />
        </div>
        <div class="dnnFormItem">
          <dnn:Label ID="RefIdLabel" runat="server" ControlName="txtRefId" Suffix=":"></dnn:Label>
            <asp:TextBox ID="txtRefId" runat="server" MaxLength="20" />
        </div>
        <div class="dnnFormItem">
          <dnn:Label ID="AdminEmailLabel" runat="server" ControlName="txtAdminEmail" Suffix=":"></dnn:Label>
            <asp:TextBox ID="txtAdminEmail" runat="server" />
        </div>
        <div class="dnnFormItem">
          <dnn:Label ID="EnableCaptchaLabel" runat="server" ControlName="cbEnableCaptcha" Suffix=":"></dnn:Label>
            <asp:CheckBox ID="cbEnableCaptcha" runat="server" />
        </div>
        <!--
        <div class="dnnFormItem">
            <dnn:label ID="lblSetting2" runat="server" />
            <asp:TextBox ID="txtSetting2" runat="server" />
        </div>
        -->
    </fieldset>


