//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhytRx45
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int LogID { get; set; }
        public byte[] LogTimeStamp { get; set; }
        public int PainNumb { get; set; }
        public int DiffNumb { get; set; }
        public string ComTxt { get; set; }
        public bool IsComplete { get; set; }
        public Nullable<int> FullSet { get; set; }
        public Nullable<int> PartialSet { get; set; }
        public int PID { get; set; }
        public int PhID { get; set; }
        public int RxID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Physician Physician { get; set; }
        public virtual RX RX { get; set; }
    }
}
