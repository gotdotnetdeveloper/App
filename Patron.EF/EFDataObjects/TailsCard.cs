//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Patron.EF.EFDataObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class TailsCard
    {
        public int CardId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> InstallId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Card { get; set; }
        public Nullable<System.DateTime> CardDate { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public string Creator { get; set; }
    }
}