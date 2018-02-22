using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;
using OpenDental;
using OpenDental.UI;
using System.IO;

namespace LaunchChrome
{//The namespace for this class must match the dll filename, including capitalization.  All other classes will typically belong to the same namespace too, but that's not a requirement.
 /// <summary>Required class.  Don't change the name.</summary>
    public class Plugin : PluginBase
    {
        private Form host;

        ///<summary></summary>
        public override Form Host
        {
            get
            {
                return host;
            }
            set
            {
                host = value;
                ConvertPluginDatabase.Begin();//if this crashes, it will bubble up and result in the plugin not loading.
                                              //If the plugin is only for personal use, then data tables do not need to be managed in the code.
                                              //They could instead be managed manually using a tool.
            }
        }

        public override bool HookMethod(object sender, string hookName, params object[] parameters)
        {//required method
            switch (hookName)
            {
                default:
                    return false;//this plugin does not implement the particular hook passed in.
            }
        }

        public override bool HookAddCode(object sender, string hookName, params object[] parameters)
        {//required method
            switch (hookName)
            {

                default:
                    return false;
            }
        }

        public override void LaunchToolbarButton(long patNum)
        {

            LaunchChrome frm = new LaunchChrome();
            frm.ShowDialog();

        }

    }
}
