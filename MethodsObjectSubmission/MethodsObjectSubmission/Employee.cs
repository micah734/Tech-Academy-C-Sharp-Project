using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectSubmission
{
    public class Employee:Person //inheriting properties from the Person class
    {
        public int Id { get; set; } //giving an property that is only accessable by the Employee class
    }
}
