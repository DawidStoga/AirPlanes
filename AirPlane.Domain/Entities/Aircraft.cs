﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AirPlane.Domain.Entities
{
   public class Aircraft
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AircraftID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please eneter a product type")]
        public string Type { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please assign to the category")]
        public string Category { get; set; }
        [Range(0,8,ErrorMessage ="Please enter the correct value")]
        public int EngineCnt { get; set; }
        public string ImageURl { get; set; }
        public byte[] ThumbnailBits { get; set; }

        public virtual PhotoFullImage FullImage { get; set; }
        public virtual ICollection<Airline> AirLines { get; set; }

    }
    public class Airline
    {
        public int AirlineId { get; set; }
        public string Name  { get; set; }
        public string Country  { get; set; }
        public byte[] Logo { get; set; }

        public virtual ICollection<Aircraft> MyProperty { get; set; }
    }
    public class PhotoFullImage
    {

        [Key, ForeignKey("Aircraft")]
        public int PhotoFullImageId { get; set; }
        public byte[] HighResolutionBits { get; set; }
        public virtual Aircraft Aircraft { get; set; }
    }
}
