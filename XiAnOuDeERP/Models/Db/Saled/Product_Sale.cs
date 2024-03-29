﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.PurchasingManagements;
using XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.WarehouseManagements;
using XiAnOuDeERP.Models.Db.Aggregate.PersonnelMatters.Users;
using XiAnOuDeERP.Models.Util;

namespace XiAnOuDeERP.Models.Db.Saled
{
    /// <summary>
    ///销售申请表
    /// </summary>
    [Table("Product_Sale")]
    public class Product_Sale : EntityBase
    {
        /// <summary>
        /// 产品
        /// </summary>
       public long FishProductId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public double ProductNumber { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        
        public string Behoof { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public long Userid { get; set; }
        /// <summary>
        /// 销售员备注
        /// </summary>
        [StringLength(255)]
        public string Des { get; set; }

        /// <summary>
        /// 准销售数量
        /// </summary>
        public double QuasiPurchaseNumber { get; set; }

       

        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal Sale_Price { get; set; }


        /// <summary>
        /// 供货商
        /// </summary>
        public  long? SupplierId { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime? Sale_Time { get; set; }
      
        /// <summary>
        /// 显示申请流程（1）领导审核物品出库（2）库管员出库（3）出库完成（4）完善销售信息，（6）领导审核（7）可销售状态，（8）销售状态，（12）撤销状态
        /// </summary>
        public int Is_Or { get; set; }

        /// <summary>
        /// 删除
        /// </summary>
       // public int Del_Or { get; set; }
        /// <summary>
        /// 删除
        /// </summary>
        public bool del_ort { get; set; }


        public virtual Z_FnishedProduct z_FnishedProduct { get; set; }

        /// <summary>
        /// 供货商
        /// </summary>
        public virtual Supplier Supplier { get; set; }


        public virtual UserDetails userDetails { get; set;}
    
    }
}