//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddEmployeeIntoEssl
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceMaster
    {
        public int Id { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Break { get; set; }
        public Nullable<int> TotalTime { get; set; }
        public Nullable<int> OfflineHours { get; set; }
    }
}
