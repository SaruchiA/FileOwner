using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileOwner
{
    public partial class Form1 : Form
    {
       // public String path;
       // public String owner;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textFile.Text = "";
            List<String> owner = new List<string>();
            List<String> files = new List<string>();
           owner= getOwner(textPath .Text );
            for (int i=0;i<owner .Count ;i++)
            {
            textFile .Text += files[i]+ " | "+owner[i ]+ System .Environment .NewLine;           
            }
        }

        public List<String > getOwner(String path)
        {
            List <String> files= new List <String> ();
            //List<String> owners = new List<String>();
            
            var owners = System.IO.File.GetAccessControl(path).GetOwner(typeof(System.Security.Principal.NTAccount));                 
            // owners is defined as Var because GetOwner() returns IEnumerable type data.

            textOwner.Text += owners + "\n";
            try
            {
                files.AddRange(Directory.GetFiles(path,"*",SearchOption.AllDirectories));                
            }
            catch (Exception ex)
            {
                textFile.Text = ex.Message ;
            }
           // owners = System.IO.File.GetAccessControl(path).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

            //String temp = System.IO.File.GetAccessControl(path).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
            //owners.AddRange(temp);
            return files;
            
        }
    }
}
