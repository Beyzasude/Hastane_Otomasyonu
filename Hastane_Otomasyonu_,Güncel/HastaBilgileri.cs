//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane_Otomasyonu__Güncel
{
    using System;
    using System.Collections.Generic;
    
    public partial class HastaBilgileri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HastaBilgileri()
        {
            this.HastaIslemleri = new HashSet<HastaIslemleri>();
            this.Recete = new HashSet<Recete>();
        }
    
        public string TCKN { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public Nullable<int> HastaYas { get; set; }
        public string HastaKanGrubu { get; set; }
        public string HastaDogumTarihi { get; set; }
        public string HastaCinsiyet { get; set; }
        public string HastaTelefonNumarasi { get; set; }
        public string HastaAdres { get; set; }
        public string HastaMedeniHal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaIslemleri> HastaIslemleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recete> Recete { get; set; }
    }
}
