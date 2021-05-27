using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekhaneTakipSistemi
{
    partial class ProgramHakkinda : Form
    {
        private char _dil;
        public ProgramHakkinda()
        {
            InitializeComponent();            
        }
        public void getDil(char dil)
        {
            _dil = dil;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void ProgramHakkinda_Load(object sender, EventArgs e)
        {
            if (_dil == 'E')
            {
                this.Text = String.Format("About Cafeteria Tracking Program");
                this.labelProductName.Text = "Cafeteria Tracking Program";
                this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
                this.labelCopyright.Text = AssemblyCopyright;
                this.labelCompanyName.Text = "Rabia KOK - Selim AGOVIC";
                this.textBoxDescription.Text = "";
            }
            else
            {
               this.Text = String.Format("About Yemekhane Takip Sistemi");
                this.labelProductName.Text = "Yemekhane Takip Sistemi";
                this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
                this.labelCopyright.Text = AssemblyCopyright;
                this.labelCompanyName.Text = "Rabia KOK - Selim AGOVIC";
                this.textBoxDescription.Text = @"
                Yemekhane takip sistemi yemekhaneye üye olan ve olmayan kişilerin yemek alımını sağlar.
                
                Üye formu hem personel hem öğrenciye yöneliktir.
                
                Üyeler şifrelerini unuturlarsa yeni şifre alabilir.
                
                Üye olmayan kişilere de bir günlük yemek hakkı tanınır.
                
                Üyelerin bakiye işlemleri yetkili tarafından gerçekleştirilir.
                        ";
            }
        }
    }
}
