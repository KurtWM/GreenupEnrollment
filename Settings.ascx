<%@ Control Language="C#" AutoEventWireup="false" Inherits="DotNetNuke.Modules.GreenupEnrollment.Settings" Codebehind="Settings.ascx.cs" %>




<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %>

	<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"><%=LocalizeString("BasicSettings")%></a></h2>
	<fieldset>
        <div class="dnnFormItem">
          <dnn:Label ID="KwhPriceLabel" runat="server" ControlName="KwhPrice" Suffix=":"></dnn:Label>
            <asp:TextBox ID="txtKwhPrice" runat="server" />
        </div>
        <!--
        <div class="dnnFormItem">
            <dnn:label ID="lblSetting2" runat="server" />
            <asp:TextBox ID="txtSetting2" runat="server" />
        </div>
        -->
    </fieldset>


