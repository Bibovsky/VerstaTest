using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VerstaTest.Models;

public partial class Order
{
    [DisplayName("Id")]
    public Guid Id { get; set; }

    
    [DisplayName("Город отправителя")]
    public string CityFrom { get; set; }
    

    [DisplayName("Город получателя")]
    public string CityTo { get; set; }

    [DisplayName("Адрес отправителя")]
    public string AdressFrom { get; set; }


    [DisplayName("Адрес получателя")]
    public string AdressTo { get; set; }
    

    [DisplayName("Вес груза")] 
    public double PackageWeight { get; set; }

    
    [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
    [DisplayName("Дата забора груза")]
    public DateTime PickUpDate { get; set; }
    

}
