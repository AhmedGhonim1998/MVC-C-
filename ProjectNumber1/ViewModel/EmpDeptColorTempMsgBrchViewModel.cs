using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProjectNumber1.ViewModel
{
    public class EmpDeptColorTempMsgBrchViewModel
    {
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public List<string> Branches { get; set; }
        public int temp { get; set; }
        public string Msg { get; set;}
        public string Color { get; set; }
    }
}
