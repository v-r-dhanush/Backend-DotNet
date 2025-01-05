using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTask
{
    public class PhotoBook
    {
        private int numPages;
        public void GetNumberPages()
        {
            Console.WriteLine(numPages);
        }

        public PhotoBook()
        {
            this.numPages = 16;
        }

        public PhotoBook(int nPages)
        {
            this.numPages = nPages;
        }


        public class BigPhotoBook : PhotoBook
        {
            public BigPhotoBook()
            {
                this.numPages = 64;
            }
        }
    }
}