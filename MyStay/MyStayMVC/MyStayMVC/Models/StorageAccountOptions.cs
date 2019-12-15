using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStayMVC.Models
{
    public class StorageAccountOptions
    {
        public string StorageAccountNameOption { get; set; }
        public string StorageAccountKeyOption { get; set; }
        public string BlobContainer { get; set; }
    }
}
