using System;
using System.Collections.Generic;
using System.Text;

namespace Members
{
    public class NameChangedEventArgs: EventArgs
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
