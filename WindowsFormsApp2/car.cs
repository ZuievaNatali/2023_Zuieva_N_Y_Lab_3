//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public car()
        {
            this.accident = new HashSet<accident>();
            this.driver = new HashSet<driver>();
            this.driver1 = new HashSet<driver>();
        }
    
        public int id_car { get; set; }
        public int id_mark { get; set; }
        public int id_model { get; set; }
        public int id_color { get; set; }
        public int id_accounting { get; set; }
        public int id_car_number { get; set; }
        public int id_categories { get; set; }
        public int id_body_type { get; set; }
        public int id_engine_type { get; set; }
        public string sit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<accident> accident { get; set; }
        public virtual accounting accounting { get; set; }
        public virtual body_type body_type { get; set; }
        public virtual car_number car_number { get; set; }
        public virtual categories categories { get; set; }
        public virtual color color { get; set; }
        public virtual engine_type engine_type { get; set; }
        public virtual mark mark { get; set; }
        public virtual model model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<driver> driver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<driver> driver1 { get; set; }
    }
}
