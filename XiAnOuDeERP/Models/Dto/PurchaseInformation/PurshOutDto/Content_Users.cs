﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.PurchasingManagements;
using XiAnOuDeERP.Models.Db.Aggregate.PersonnelMatters.Users;
using XiAnOuDeERP.Models.Util;

namespace XiAnOuDeERP.Models.Dto.PurchaseInformation.PurshOutDto
{
    public class Content_Users:InputBase
    {
        /// <summary>
       /// 签核id
       /// </summary>

        public long Id { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>

        public long user_Id { get; set; }
        /// <summary>
        /// 内容id
        /// </summary> 
        public long Purchase_Id { get; set; }
        /// <summary>
        ///描述
        /// </summary>
      
        public string ContentDes { get; set; }
        /// <summary>
        /// 仓库id
        /// </summary>

        public long enportid { get; set; }


        public Purchase Purchase { get; set; }

        public UserDetails UserDetails { get; set; }
    }
}