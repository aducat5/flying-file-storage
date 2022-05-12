using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer.Model
{
    public record File
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ContentType { get; set; } = "";
        public string Size { get; set; } = "";
        public byte[] Data { get; set; } = new byte[] { };
        public DateTime CreatedAt { get; set; }
    }
}
