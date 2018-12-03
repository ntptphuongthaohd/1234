namespace PregnancyData.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class preg_phone
    {
        public int id { get; set; }

        public int? profession_id { get; set; }

        [StringLength(1024)]
        public string phone_number { get; set; }

        public int? user_id { get; set; }

        public virtual preg_profession preg_profession { get; set; }

        public virtual preg_profession preg_profession1 { get; set; }

        public virtual preg_user preg_user { get; set; }

        public virtual preg_user preg_user1 { get; set; }
    }
}
