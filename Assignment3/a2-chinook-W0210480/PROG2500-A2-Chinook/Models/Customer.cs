using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace PROG2500_A2_Chinook.Models
{
    public partial class Customer
    {
        public string FormattedName { get { return string.Format("{0} {1}", LastName, FirstName); } }

        public string FormattedCityState { get { return string.Format("{0}, {1}", City, State); } }

        public string FormattedInfoBlock
        {
            get
            {
                return string.Format
                    (FormattedName + "\n" + FormattedCityState + "\n{0}\n{1}", Country, Email);
            }
        }

    }
}
