using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace ServiceLifeExtensionTool
{
    public partial class FormServiceLifeExtensionTool : Form
    {
        #region Properties
        /// <summary>
        /// Config file null path to main C drive.
        /// </summary>
        public static string ConfigFileFullPath =>
            //return AppDomain.CurrentDomain.BaseDirectory;
            "C:\\GeNOsylAds";

        /// <summary>
        /// Config file short name.
        /// </summary>
        public static string ConfigFileShortName => "GeNOsylAcuteDS";

        /// <summary>
        /// Config file short name.
        /// </summary>
        public static string FlagFileName => "ServiceLifeExtension.dat";

        /// <summary>
        /// Bool for whether or not the xml was successfully parsed
        /// </summary>
        public bool XmlException { get; set; } = false;

        #endregion
        public FormServiceLifeExtensionTool()
        {
            InitializeComponent();
        }

        private void FormServiceLifeExtensionTool_Load(object sender, EventArgs e)
        {
            bool extensionFlagFound = File.Exists(ConfigFileFullPath + "\\" + FlagFileName);

            // Load the Config.Xml and set the Current due date if successful
            LoadXmlConfigFile();

            if (extensionFlagFound)
            {
                textBoxExtensionApplied.Text = "Record of Extension already applied";
                textBoxPlannedExtension.Text = "N/A";
                buttonSetDueDate.Enabled = false;
            }
            else
            {
                textBoxExtensionApplied.Text = "No record of extention found";
                // the next method calculates the extension and sets the extended dates
                ExtendServiceLife();
            }
        }

        private void ExtendServiceLife()
        {
            DateTime currentDueDate;
            if (XmlException || string.IsNullOrEmpty(textBoxCurrentDate.Text))
            {
                textBoxCurrentDate.Text = "Service Due Date not found!";
                textBoxPlannedExtension.Text = "Extension for Due Date cannot be Calculated";
                buttonSetDueDate.Enabled = false;
            }
            else
            {
                try
                {
                    currentDueDate = DateTime.Parse(textBoxCurrentDate.Text);
                    TimeSpan ts = currentDueDate.Subtract(DateTime.Now);
                    // Make sure we dont add another year if it's already been extended
                    if (ts.TotalDays < 365)
                    {
                        currentDueDate = currentDueDate.AddYears(1);
                        textBoxPlannedExtension.Text = currentDueDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        textBoxPlannedExtension.Text = textBoxCurrentDate.Text;
                    }
                }
                catch
                {
                    textBoxCurrentDate.Text = "Service Due Date not found!";
                    textBoxPlannedExtension.Text = "Extension for Due Date cannot be Calculated";
                    buttonSetDueDate.Enabled = false;
                }
            }
        }

        public void LoadXmlConfigFile()
        {
            string primaryConfigFileName = ConfigFileFullPath + "\\" + ConfigFileShortName + ".xml";
            string serviceDueDate;
            try
            {
                XmlDocument configDoc = new XmlDocument();
                configDoc.Load(primaryConfigFileName);
                XmlNode node = configDoc.DocumentElement.SelectSingleNode("/ConfigurationManager/ServiceDueDate");
                serviceDueDate = node.InnerText;
            }
            catch (Exception xmlEx)
            {
                serviceDueDate = "Service Due Date not found: " + xmlEx;
                XmlException = true;

            }
            textBoxCurrentDate.Text = serviceDueDate;
        }

        private void buttonSetDueDate_Click(object sender, EventArgs e)
        {
            string primaryConfigFileName = ConfigFileFullPath + "\\" + ConfigFileShortName + ".xml";
            string serviceDueDate;
            try
            {
                XmlDocument configDoc = new XmlDocument();
                configDoc.Load(primaryConfigFileName);
                XmlNode node = configDoc.DocumentElement.SelectSingleNode("/ConfigurationManager/ServiceDueDate");
                node.InnerText = textBoxPlannedExtension.Text;
                configDoc.Save(primaryConfigFileName);
                // Set the indicator that the service due date is already extended
                File.Create(ConfigFileFullPath + "\\" + FlagFileName);
                textBoxExtensionApplied.Text = "Extension applied succesfully";
                buttonSetDueDate.Enabled = false;
            }
            catch (Exception xmlEx)
            {
                textBoxExtensionApplied.Text = "Set due date failed: " + xmlEx;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
