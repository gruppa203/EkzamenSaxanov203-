//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkzamenSaxanov203
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tovar
    {
        public string Artikul { get; set; }
        public string Naimenovanie_Tovar { get; set; }
        public string ed_izm_Tovar { get; set; }
        public decimal Stoimost_Tovar { get; set; }
        public int Maks_Skidka_Tovar { get; set; }
        public int Proizvoditel_Tovar { get; set; }
        public int Postavshik_Tovar { get; set; }
        public int Kategorii_Tovar { get; set; }
        public double Deistv_Tovar { get; set; }
        public int Kol_Vo_Tovar { get; set; }
        public string Opisanie_Tovar { get; set; }
        public string Izobrajenie_Tovar { get; set; }
    
        public virtual Kategorii Kategorii { get; set; }
        public virtual Pastovshik Pastovshik { get; set; }
        public virtual Proizvoditel Proizvoditel { get; set; }
    }
}
