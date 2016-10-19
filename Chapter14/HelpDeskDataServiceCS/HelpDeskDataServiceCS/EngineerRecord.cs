﻿//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should reference the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be:
//"Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskDataServiceCS
{
    //Listing 9-1. Entity Class for Engineers
    public class EngineerRecord
    {
        [Key(), Editable(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Surname required"), StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Firstname required"), StringLength(50)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "DateOfBirth required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "SecurityVetted required")]
        public bool SecurityVetted { get; set; }

        [Editable(false)]
        public int IssueCount { get; set; }
    }
}