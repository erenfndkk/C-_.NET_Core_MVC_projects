﻿using System;

namespace agriculturePresentation.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactMessage { get; set; }
        public string ContactMail { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
