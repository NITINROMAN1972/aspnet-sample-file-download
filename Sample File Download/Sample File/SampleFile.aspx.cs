using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sample_File_SampleFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnExclUpload_Click(object sender, EventArgs e)
    {
        if (fileExcel.HasFile)
        {
            // logic here
            // visit git reposiotry: https://github.com/Millstack/aspnet-excel-upload.git
            // visit git repository: https://github.com/Millstack/aspnet-import-excel-to-db.git
        }
    }

    public void AlertMessage(string message)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), " alert('" + message + "');", true);
    }

    protected void btnSample_Click(object sender, EventArgs e)
    {
        // the file has to be there, at the sourse

        //string filename = "~/Samples/Sample Reference File.xlsx"; // excel file
        string filename = "~/Samples/Milind Khamkar Infosys Offer Letter.pdf"; // pdf file

        if (filename != "")
        {
            string path = Server.MapPath(filename);
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            if (file.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.WriteFile(file.FullName);
                Response.End();
            }
            else
            {
                Response.Write("This file does not exist.");
            }
        }
        else
        {
            AlertMessage("Sample file does not exist!");
        }
    }
}