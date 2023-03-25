﻿using WebLuto.Common.Interfaces;

namespace WebLuto.Common
{
    public class BaseEntity : IBaseEntity
    {
        public long Id { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

        public long? CreateUserId { get; set; }

        public long? UpdateUserId { get; set; }
    }
}
