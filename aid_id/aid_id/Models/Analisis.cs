using System;
using System.Collections.Generic;


namespace aid_id.Models.BBDD
{

    
public partial class Analisis
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Analisis()
    {

        this.Comidas = new HashSet<Comidas>();

    }


    public long id_analisis { get; set; }

    public byte valor { get; set; }

    public System.DateTime fecha_hora { get; set; }

    public Nullable<byte> intensidad_deporte { get; set; }

    public long id_usuario { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Comidas> Comidas { get; set; }

    public virtual Usuarios Usuarios { get; set; }

}


