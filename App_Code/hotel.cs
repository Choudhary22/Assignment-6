﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class adminlogin
{
    public string username { get; set; }
    public string password { get; set; }
}

public partial class book
{
    public int Id { get; set; }
    public string bookin { get; set; }
    public string bookout { get; set; }
    public string children { get; set; }
    public string rooms { get; set; }
    public string username { get; set; }
}

public partial class contactu
{
    public int Id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string email { get; set; }
    public string mobileno { get; set; }
}

public partial class register
{
    public string username { get; set; }
    public string email { get; set; }
    public string mobileno { get; set; }
    public string address { get; set; }
    public string profession { get; set; }
}