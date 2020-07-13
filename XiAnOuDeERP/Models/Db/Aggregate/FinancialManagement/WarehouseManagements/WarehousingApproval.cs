﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using XiAnOuDeERP.Models.Db.Aggregate.PersonnelMatters.Users;
using XiAnOuDeERP.Models.Util;

namespace XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.WarehouseManagements
{
    /// <summary>
    /// 入库申请审核记录表
    /// </summary>
    [Table("WarehousingApproval")]
    public class WarehousingApproval:EntityBase
    {
        /// <summary>
        /// 入库申请Id
        /// </summary>
        public long WarehousingId { get; set; }

        /// <summary>
        /// 审批人Id
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsApproval { get; set; }

        /// <summary>
        /// 审核人用户类型key
        /// </summary>
        public string UserTypeKey { get; set; }

        /// <summary>
        /// 审批顺序
        /// </summary>
        public int ApprovalIndex { get; set; }

        /// <summary>
        /// 入库申请
        /// </summary>
        public virtual Warehousing Warehousing { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public virtual UserDetails User { get; set; }
    }
}