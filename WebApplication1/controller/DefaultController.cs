using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace wxminigame.server
{
    [Route("/file")]
    public class FileController : ControllerBase
    {
        [Route("test/{parameter}")]
        public string Name()
        {
            return "AndyFool's, 福的测试";
        }

    }
}
