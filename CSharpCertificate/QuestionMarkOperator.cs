using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCertificate
{
    class QuestionMarkOperator
    {
        public void QuestionMarkOperators()
        {
            /*
         •	 Nullable<T> is an alternative of “?” operator. The above example can be written as
                Nullable<bool> isMarried = null;
         •	 Value type is boxed whenever it becomes nullable.
            */
            bool? isMarried = null;
            bool married = isMarried ?? false;
        }
    }
}
