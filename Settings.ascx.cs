/*
' Copyright (c) 2012  DotNetNuke Corporation
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Tabs;
using DotNetNuke.Modules.Console.Components;
using DotNetNuke.Security.Permissions;
using DotNetNuke.Services.Localization;



namespace DotNetNuke.Modules.GreenupEnrollment
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Settings class manages Module Settings
    /// 
    /// Typically your settings control would be used to manage settings for your module.
    /// There are two types of settings, ModuleSettings, and TabModuleSettings.
    /// 
    /// ModuleSettings apply to all "copies" of a module on a site, no matter which page the module is on. 
    /// 
    /// TabModuleSettings apply only to the current module on the current page, if you copy that module to
    /// another page the settings are not transferred.
    /// 
    /// If you happen to save both TabModuleSettings and ModuleSettings, TabModuleSettings overrides ModuleSettings.
    /// 
    /// Below we have some examples of how to access these settings but you will need to uncomment to use.
    /// 
    /// Because the control inherits from GreenupEnrollmentSettingsBase you have access to any custom properties
    /// defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
    /// </summary>
    /// -----------------------------------------------------------------------------
  public partial class Settings : GreenupEnrollmentSettingsBase
    {

        #region Base Method Implementations

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// LoadSettings loads the settings from the Database and displays them
        /// </summary>
        /// -----------------------------------------------------------------------------
        public override void LoadSettings()
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    //Check for existing settings and use those on this page
                    //Settings["SettingName"]

                    if (Settings.ContainsKey("KwhPrice"))
                    {
                      txtKwhPrice.Text = Convert.ToString(TabModuleSettings["KwhPrice"]);
                    }

                    if (Settings.ContainsKey("AdminEmail"))
                    {
                      txtAdminEmail.Text = Convert.ToString(TabModuleSettings["AdminEmail"]);
                    }

                    if (Settings.ContainsKey("SubscriptonName"))
                    {
                      txtSubscriptonName.Text = Convert.ToString(TabModuleSettings["SubscriptonName"]);
                    }

                    if (Settings.ContainsKey("RefId"))
                    {
                      txtRefId.Text = Convert.ToString(TabModuleSettings["RefId"]);
                    }

                    if (Settings.ContainsKey("EnableCaptcha"))
                    {
                      cbEnableCaptcha.Checked = Convert.ToBoolean(TabModuleSettings["EnableCaptcha"]);
                    }
                  
                    //if ((string)TabModuleSettings["EnableCaptcha"] != string.Empty)
                    //{
                    //  bool show;
                    //  if (!bool.TryParse((string)TabModuleSettings["EnableCaptcha"], out show))
                    //  {
                    //    show = true; // Default to showing the description.
                    //  }
                    //  cbEnableCaptcha.Checked = show;
                    //}

			
                    /* uncomment to load saved settings in the text boxes
                    if (Settings.Contains("Setting2"))
                        txtSetting2.Text = Settings["Setting2"].ToString();

                    */



                }
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpdateSettings saves the modified settings to the Database
        /// </summary>
        /// -----------------------------------------------------------------------------
        public override void UpdateSettings()
        {
            try
            {
                ModuleController modules = new ModuleController();

                //module settings
                modules.UpdateTabModuleSetting(TabModuleId, "KwhPrice", txtKwhPrice.Text);
                modules.UpdateTabModuleSetting(TabModuleId, "AdminEmail", txtAdminEmail.Text);
                modules.UpdateTabModuleSetting(TabModuleId, "SubscriptonName", txtSubscriptonName.Text);
                modules.UpdateTabModuleSetting(TabModuleId, "RefId", txtRefId.Text);
                modules.UpdateTabModuleSetting(TabModuleId, "EnableCaptcha", cbEnableCaptcha.Checked.ToString());
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        #endregion

    }

}

