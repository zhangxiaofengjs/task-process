using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xworks.taskprocess
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
			try
			{
				DirectoryInfo di = new DirectoryInfo(@"D:\#tmp\0627");  
				DirectorySecurity s = new DirectorySecurity(@"D:\#tmp\0627", AccessControlSections.Access);  
       
				//判断目录是否 可以访问  
				if (!s.AreAccessRulesProtected)
				{
				}
				FileInfo file = new FileInfo(@"D:\#tmp\0627");
				AuthorizationRuleCollection accessRules = file.GetAccessControl().GetAccessRules(true, true,
										typeof(System.Security.Principal.SecurityIdentifier));
				foreach (FileSystemAccessRule rule in accessRules)
				{
					Debug.Write(rule.IdentityReference.Translate(typeof(NTAccount)) + "   ");
					Debug.Write(rule.FileSystemRights);
					Debug.WriteLine("  " + rule.AccessControlType);
				}
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("aaa");
			}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTaskList());
        }
       
    }
}
