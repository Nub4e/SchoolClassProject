
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EntityFrameworkModel.Model
{

using System;
    using System.Collections.Generic;
    
public partial class StudentContactInfo
{

    public int ContactInfoId { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public int StudentId { get; set; }



    public virtual Student Student { get; set; }

}

}
