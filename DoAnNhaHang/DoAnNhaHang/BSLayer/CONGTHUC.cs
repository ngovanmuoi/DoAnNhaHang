//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnNhaHang.BSLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONGTHUC
    {
        public string MAMON { get; set; }
        public string MANGUYENLIEU { get; set; }
        public string HAMLUONG { get; set; }
    
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
        public virtual THUCDON THUCDON { get; set; }
    }
}
