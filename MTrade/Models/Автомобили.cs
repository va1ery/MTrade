//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTrade.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Автомобили
    {
        public int Код_автомобиля { get; set; }
        public string Марка { get; set; }
        public Nullable<System.DateTime> Дата_производства { get; set; }
        public string Цвет { get; set; }
        public string Номер_кузова { get; set; }
        public string Номер_двигателя { get; set; }
        public string Характеристики { get; set; }
        public Nullable<decimal> Цена { get; set; }
        public int Код_оборудования_1 { get; set; }
        public int Код_оборудования_2 { get; set; }
        public int Код_оборудования_3 { get; set; }
        public int Код_производителя { get; set; }
        public int Код_типа_кузова { get; set; }
        public Nullable<int> Код_заказчика { get; set; }
        public int Код_сотрудника { get; set; }
    
        public virtual Дополнительное_оборудование Дополнительное_оборудование { get; set; }
        public virtual Дополнительное_оборудование Дополнительное_оборудование1 { get; set; }
        public virtual Дополнительное_оборудование Дополнительное_оборудование2 { get; set; }
        public virtual Заказчики Заказчики { get; set; }
        public virtual Производители Производители { get; set; }
        public virtual Сотрудники Сотрудники { get; set; }
        public virtual Тип_кузова Тип_кузова { get; set; }
    }
}
