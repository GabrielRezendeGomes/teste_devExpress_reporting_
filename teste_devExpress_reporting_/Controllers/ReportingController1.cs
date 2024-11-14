using Microsoft.AspNetCore.Mvc;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;

namespace teste_devExpress_reporting_.Controllers
{
    public class CustomWebDocumentViewerController : WebDocumentViewerController
    {
        public CustomWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService)
            :base(controllerService)
        {
            
        }
    }
}
