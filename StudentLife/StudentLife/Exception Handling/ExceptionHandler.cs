using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Exception_Handling
{
    class ExceptionHandler
    {
        void HandleException (Exception ex)
        {
            switch (ex.InnerException)
            {
                //TO DO: Do stuff depending on the error.
                //Perhaps call a method for displaying an appropriate message?
            }
        }
    }
}
