using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using G1ANT.Addon.Facebook.Properties;
using System.IO;

// Please remember to refresh G1ANT.Language.dll in references

namespace G1ANT.Addon.Facebook
{
    [Addon(Name = "Facebook", Tooltip = "Automate Facebook")]
    [Copyright(Author = "Company Ltd", Copyright = "Company Ltd", Email = "support@company.com", Website = "www.company.com")]
    [License(Type = "LGPL", ResourceName = "License.txt")]
    //[CommandGroup(Name = "", Tooltip = "")]
    public class FacebookAddon : Language.Addon
    {
        public override void LoadDlls()
        {
            UnpackDrivers();
            base.LoadDlls();
        }

        private void UnpackDrivers()
        {
            var unpackFolder = AbstractSettingsContainer.Instance.UserDocsAddonFolder.FullName;
            var embeddedResourceDictionary = new Dictionary<string, byte[]>()
            {
                { "chromedriver.exe", Resources.chromedriver },
                { "geckodriver.exe", Resources.geckodriver },
                { "IEDriverServer.exe", Resources.IEDriverServer }
            };
            foreach (var embededResource in embeddedResourceDictionary.Where(e => !DoesFileExist(unpackFolder, e.Key) || !AreFilesOfTheSameLength(e.Value.Length, unpackFolder, e.Key)))
            {
                try
                {
                    using (FileStream stream = File.Create(Path.Combine(unpackFolder, embededResource.Key)))
                    {
                        stream.Write(embededResource.Value, 0, embededResource.Value.Length);
                    }
                }
                catch (Exception ex) { RobotMessageBox.Show(ex.Message); }
            }
        }

        private bool DoesFileExist(string folder, string fileName)
        {
            return File.Exists(Path.Combine(folder, fileName));
        }

        private bool AreFilesOfTheSameLength(int length, string folder, string fileName)
        {
            return length == new FileInfo(Path.Combine(folder, fileName)).Length;
        }
    }
}