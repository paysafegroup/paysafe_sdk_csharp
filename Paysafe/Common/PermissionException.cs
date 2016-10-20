using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace optimal.common
{
    public class PermissionException : NetbanxException
    {
        public PermissionException()
            : base()
        {

        }

        public PermissionException(String message)
            : base(message)
        {

        }

        public PermissionException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
