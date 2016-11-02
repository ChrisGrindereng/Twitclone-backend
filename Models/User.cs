using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class User: HasId, CreatedAt{
    public int Id{get; set;}
    public string Username{get; set;}
    public string AvatarURL{get; set;}
    public DateTime CreatedAt{get; set;}

}    