//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpertiseWCFService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expertises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Expertises()
        {
            this.ExpCrit = new HashSet<ExpCrit>();
            this.ExpertiseMark = new HashSet<ExpertiseMark>();
            this.ProjectExpertise = new HashSet<ProjectExpertise>();
            this.ExpertiseExpert = new HashSet<ExpertiseExpert>();
        }
    
        public int id_expertise { get; set; }
        public string name_expertise { get; set; }
        public System.DateTime date_expertise { get; set; }
        public bool end_expertise { get; set; }
        public int count_proj_expertise { get; set; }
        public int id_fos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpCrit> ExpCrit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpertiseMark> ExpertiseMark { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectExpertise> ProjectExpertise { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpertiseExpert> ExpertiseExpert { get; set; }
    }
}
