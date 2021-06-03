using System.Reflection;
using System.Windows.Forms;

namespace TextFileSearch
{
    /// <summary>
    /// The form with information about the application.
    /// </summary>
    public partial class AboutBoxForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
        /// </summary>
        public AboutBoxForm()
        {
            InitializeComponent();
            logoPictureBox.Image = Resources.TextFileSearch_96x;
            Text = string.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            textBoxDescription.Text = AssemblyDescription;
        }

        private static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != string.Empty)
                    {
                        return titleAttribute.Title;
                    }
                }

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            }
        }

        private static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        private static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
    }
}
