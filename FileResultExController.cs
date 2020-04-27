using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class FileResultExController : Controller
    {
        // GET: FileResultEx
       public FileResult PDFFile()
        {
            return File("~/Folder/AdmitCard.pdf","application/pdf");
        }
        [HttpGet]
        public FileResult DocFile()
        {
            return File("~/Folder/Resume.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
    }
}