using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookv2
{
    class Ebook
    {
        private string title;
        private string status;
        private int nopage;
        private int cpage;

        public Ebook(string title_, int nopage_, int cpage_,string status_)
        {
            this.Title = title_;
            this.noPage = nopage_;
            this.cPage = cpage_;
            this.Status = status_;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int noPage
        {
            get { return nopage; }
            set { nopage = value; }
        }

        public int cPage
        {
            get { return cpage; }
            set { cpage = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int nextPage(int current_page)
        {
            return (current_page++);
        }

        public int prevPage(int current_page)
        {
            return (current_page--);
        }
    }
}
